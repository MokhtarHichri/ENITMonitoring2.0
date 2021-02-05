/*
    __  ___               _  __                _                  ___      ____ 
   /  |/  /____   ____   (_)/ /_ ____   _____ (_)____   ____ _   |__ \    / __ \
  / /|_/ // __ \ / __ \ / // __// __ \ / ___// // __ \ / __ `/   __/ /   / / / /
 / /  / // /_/ // / / // // /_ / /_/ // /   / // / / // /_/ /   / __/ _ / /_/ / 
/_/  /_/ \____//_/ /_//_/ \__/ \____//_/   /_//_/ /_/ \__, /   /____/(_)\____/  
                                                     /____/                     
Réalisé par: Mokhtar Hichri dans le cadre du bureau d'études "Supervision des systèmes industriels"
Novembre 2021 
https://github.com/MokhtarHichri/ENITMonitoring2.0

A travers ce bureau d’études, nous allons réaliser une interface graphique permettant 
d’effectuer la supervision d’une cellule flexible à l’ENIT communicant grâce à Open Protocol Communication. 

Plus précisément le client NI OPC. 

L’interface graphique est programmée en utilisant le langage de programmation C#
Librairies utilisées :
•	NI Measurement Studio

Le système contient au total 6 interfaces:
-4 interfaces de supervision individuelles
-1 interface de supervision générale 
-1 Menu principal

Ceci est le code source de l'interface de supervision générale.

Pour plus d'informations, cliquez sur le bouton "Help" ou consultez le fichier readme.pdf se trouvant au path du projet.
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NationalInstruments.NetworkVariable;


namespace Testing_Value_8Bit
{
    public partial class overview : Form
    {
        public NetworkVariableSubscriber<UInt16> Input1;
        public NetworkVariableWriter<UInt16> Output1;
        public NetworkVariableSubscriber<UInt16> Input2;
        public NetworkVariableWriter<UInt16> Output2;
        public NetworkVariableSubscriber<UInt16> Input3;
        public NetworkVariableWriter<UInt16> Output3;
        public NetworkVariableSubscriber<UInt16> Input4;
        public NetworkVariableWriter<UInt16> Output4;
        public NetworkVariableSubscriber<bool> Status;
        public NetworkVariableSubscriber<bool> Emergency;
        public NetworkVariableWriter<bool> S1Status;
        public NetworkVariableWriter<bool> S2Status;
        public NetworkVariableWriter<bool> S3Status;
        public NetworkVariableWriter<bool> S4Status;
        public Button[] buttonsarray = new Button[20];
        List<Button> buttonslist;
        //;

        /* LOCATIONS HERE vvvvvvvv
         * networkVariableDataSource1.Bindings[0].Location Overall System
         * networkVariableDataSource1.Bindings[1].Location Emergency Stop
         * networkVariableDataSource1.Bindings[2].Location S1 IN
         * networkVariableDataSource1.Bindings[3].Location S1 OUT
         * networkVariableDataSource1.Bindings[4].Location S2 IN
         * networkVariableDataSource1.Bindings[5].Location S2 OUT
         * etc...
         */
        private string boolreader;
        public overview()
        {
            InitializeComponent();
            ConnectOPCServer();
        }
        private void ConnectOPCServer()
        {
            Status = new NetworkVariableSubscriber<bool>(networkVariableDataSource1.Bindings[0].Location);
            S1Status = new NetworkVariableWriter<bool>(networkVariableDataSource1.Bindings[10].Location);
            S2Status = new NetworkVariableWriter<bool>(networkVariableDataSource1.Bindings[11].Location);
            S3Status = new NetworkVariableWriter<bool>(networkVariableDataSource1.Bindings[12].Location);
            S4Status = new NetworkVariableWriter<bool>(networkVariableDataSource1.Bindings[13].Location);
            Emergency = new NetworkVariableSubscriber<bool>(networkVariableDataSource1.Bindings[1].Location);
            Input1 = new NetworkVariableSubscriber<UInt16>(networkVariableDataSource1.Bindings[3].Location);
            Output1 = new NetworkVariableWriter<UInt16>(networkVariableDataSource1.Bindings[2].Location);
            Input2 = new NetworkVariableSubscriber<UInt16>(networkVariableDataSource1.Bindings[5].Location);
            Output2 = new NetworkVariableWriter<UInt16>(networkVariableDataSource1.Bindings[4].Location);
            Input3 = new NetworkVariableSubscriber<UInt16>(networkVariableDataSource1.Bindings[7].Location);
            Output3 = new NetworkVariableWriter<UInt16>(networkVariableDataSource1.Bindings[6].Location);
            Input4 = new NetworkVariableSubscriber<UInt16>(networkVariableDataSource1.Bindings[9].Location);
            Output4 = new NetworkVariableWriter<UInt16>(networkVariableDataSource1.Bindings[8].Location);

            //Configuring Handlers

            Status.DataUpdated += new EventHandler<DataUpdatedEventArgs<bool>>(NeoStat);
            Emergency.DataUpdated += new EventHandler<DataUpdatedEventArgs<bool>>(EmergencyStop);
            Input1.DataUpdated += new EventHandler<DataUpdatedEventArgs<UInt16>>(Input1New);
            Input2.DataUpdated += new EventHandler<DataUpdatedEventArgs<UInt16>>(Input2New);
            Input3.DataUpdated += new EventHandler<DataUpdatedEventArgs<UInt16>>(Input3New);
            Input4.DataUpdated += new EventHandler<DataUpdatedEventArgs<UInt16>>(Input4New);
            //Custom Handlers for Queues and positions


            //Connecting
            Status.Connect();
            Emergency.Connect();
            Input1.Connect();
            Input2.Connect();
            Input3.Connect();
            Input4.Connect();
            S1Status.Connect();
            S2Status.Connect();
            S3Status.Connect();
            S4Status.Connect();
        }

        private void NeoStat(object Sender, DataUpdatedEventArgs<bool> e)
        {
            if (e.Data.HasValue)
            {
                bool data = e.Data.GetValue();
                led1.Value = data;
            }
        }

        /*-EmergencyStop----------------------------------------------------------/
        *                                                                         /
        * Arrêt d'urgence: Ecriture de la valeur au niveau de la variable OPC     /
        *                                                                         /
        *------------------------------------------------------------------------*/
        private void EmergencyStop(object Sender, DataUpdatedEventArgs<bool> e)
        {
            if (e.Data.HasValue)
            {
                bool data = e.Data.GetValue();
                if (data)
                {
                    timer1.Stop();
                }
                else
                {
                    timer1.Start();
                }

            }
        }

        /*-InputiNew--------------------------------------------------------------/
        *                                                                         /
        * Handler des màj des valeurs des différentes entrées des stations        /
        *                                                                         /
        *------------------------------------------------------------------------*/
        private void Input1New(object Sender, DataUpdatedEventArgs<UInt16> e)
        {
            if (e.Data.HasValue)
            {
                UInt16 data = e.Data.GetValue();
                boolreader = Convert.ToString(data, 2);
                bool[] boolarray = new bool[17];
                boolarray = boolreader.Select(c => c == '1').ToArray();
                //boolarray.Reverse();
                NationalInstruments.UI.WindowsForms.Led[] leds = { E10, E11, E12, E13, E14, E15, E16, E17, E18, E19, E110, E111, E112, E113, E114, E115 };
                for (int i = 0; i < boolarray.Length; i++)
                {
                    leds[i].Value = boolarray[i];
                }
                for (int i = boolarray.Length; i < 16; i++)
                {
                    leds[i].Value = false;
                }
            }
        }

        private void Input2New(object Sender, DataUpdatedEventArgs<UInt16> e)
        {
            if (e.Data.HasValue)
            {
                UInt16 data = e.Data.GetValue();
                boolreader = Convert.ToString(data, 2);
                bool[] boolarray = new bool[17];
                boolarray = boolreader.Select(c => c == '1').ToArray();
                //boolarray.Reverse();
                NationalInstruments.UI.WindowsForms.Led[] leds = { E20, E21, E22, E23, E24, E25, E26, E27, E28, E29, E210, E211, E212, E213, E214, E215 };
                for (int i = 0; i < boolarray.Length; i++)
                {
                    leds[i].Value = boolarray[i];
                }
                for (int i = boolarray.Length; i < 16; i++)
                {
                    leds[i].Value = false;
                }
            }
        }
        private void Input3New(object Sender, DataUpdatedEventArgs<UInt16> e)
        {
            if (e.Data.HasValue)
            {
                UInt16 data = e.Data.GetValue();
                boolreader = Convert.ToString(data, 2);
                bool[] boolarray = new bool[17];
                boolarray = boolreader.Select(c => c == '1').ToArray();

                NationalInstruments.UI.WindowsForms.Led[] leds = { E30, E31, E32, E33, E34, E35, E36, E37, E38, E39, E310, E311, E312, E313, E314, E315 };
                for (int i = 0; i < boolarray.Length; i++)
                {
                    leds[i].Value = boolarray[i];
                }
                for (int i = boolarray.Length; i < 16; i++)
                {
                    leds[i].Value = false;
                }
            }
        }
        private void Input4New(object Sender, DataUpdatedEventArgs<UInt16> e)
        {
            if (e.Data.HasValue)
            {
                UInt16 data = e.Data.GetValue();
                boolreader = Convert.ToString(data, 2);
                bool[] boolarray = new bool[17];
                boolarray = boolreader.Select(c => c == '1').ToArray();

                NationalInstruments.UI.WindowsForms.Led[] leds = { E40, E41, E42, E43, E44, E45, E46, E47, E48, E49, E410, E411, E412, E413, E414, E415 };
                for (int i = 0; i < boolarray.Length; i++)
                {
                    leds[i].Value = boolarray[i];
                }
                for (int i = boolarray.Length; i < 16; i++)
                {
                    leds[i].Value = false;
                }
            }
        }
        private void overview_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(280, 230);
            buttonslist = new List<Button>();
            spawn();

            buttonslist.Add(button1);

        }
        /*
         * Add the following:
         * When X is reached, enable led Done
         * add Button Spawning Done
         * Add Button Despawning Done
         * Add a reset Button 
         */
        private void move_right(Button sender)
        {
            sender.Location = new Point(sender.Location.X + 1, sender.Location.Y);
        }
        private void move_left(Button sender)
        {
            sender.Location = new Point(sender.Location.X - 1, sender.Location.Y);
        }
        private void move_up(Button sender)
        {
            sender.Location = new Point(sender.Location.X, sender.Location.Y - 1);
        }

        private void move_down(Button sender)
        {
            sender.Location = new Point(sender.Location.X, sender.Location.Y + 1);
        }

        /*-timer1_Tick------------------------------------------------------------/
        *                                                                         /
        * Gestion de l'animation, synchronisation des leds et déplacement des     /
        * palettes.                                                               /
        *                                                                         /
        *------------------------------------------------------------------------*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = button1.Location.X.ToString();
            label13.Text = button1.Location.Y.ToString();
            foreach (Button button in buttonslist)
            {
                //Led Station 1
                if ((button.Location.X == 395) && (button.Location.Y == 220))
                {
                    E10.Value = true;
                }
                if ((button.Location.X == 395) && (button.Location.Y == 210))
                {
                    E11.Value = true;

                }
                if ((button.Location.X == 395) && (button.Location.Y == 154))
                {
                    E12.Value = true;
                    E11.Value = false;
                }

                if ((button.Location.X == 395) && (button.Location.Y == 120))
                {
                    E13.Value = true;
                    E12.Value = false;
                }
                if ((button.Location.X == 395) && (button.Location.Y == 95))
                {
                    E14.Value = true;
                    E13.Value = false;
                }
                if ((button.Location.X == 395) && (button.Location.Y == 75))
                {
                    E15.Value = true;
                    E14.Value = false;
                }
                if ((button.Location.X == 535) && (button.Location.Y == 75))
                {
                    E10.Value = false;
                    E14.Value = false;
                    E111.Value = true;
                    E110.Value = false;
                }
                if ((button.Location.X == 535) && (button.Location.Y == 114))
                {
                    E112.Value = true;
                    E111.Value = false;
                }
                if ((button.Location.X == 535) && (button.Location.Y == 155))
                {
                    E113.Value = true;
                    E112.Value = false;
                }
                if ((button.Location.X == 535) && (button.Location.Y == 200))
                {
                    E114.Value = true;
                    E113.Value = false;
                }
                if ((button.Location.X == 535) && (button.Location.Y == 229))
                {
                    E115.Value = true;
                    E114.Value = false;
                }
                else
                {
                    E115.Value = false;
                }


                //Station 1
                if ((button.Location.X == 395) && (button.Location.Y > 75) && (button.Location.Y == 230) && (E10.Value == false) && (S10.Value))
                {
                    move_up(button);
                }
                if ((button.Location.X == 395) && (button.Location.Y > 75) && (button.Location.Y < 230))
                {
                    move_up(button);
                }
                if ((button.Location.X < 535) && (button.Location.Y == 75))
                {
                    move_right(button);
                }

                if ((button.Location.X == 535) && (button.Location.Y < 230))
                {
                    move_down(button);
                }
                //Station 2
                if ((button.Location.X == 815) && (button.Location.Y > 75) && (button.Location.Y == 230) && (E20.Value == false) && (S20.Value))
                {
                    move_up(button);
                }
                if ((button.Location.X == 815) && (button.Location.Y > 75) && (button.Location.Y < 230))
                {
                    move_up(button);
                }
                if ((button.Location.X < 955) && (button.Location.Y == 75))
                {
                    move_right(button);
                }
                if ((button.Location.X == 955) && (button.Location.Y < 230))
                {
                    move_down(button);
                }
                //Station 3
                if ((button.Location.X == 955) && (button.Location.Y > 359) && (button.Location.Y < 520) && (E34.Value == false) && (S30.Value))
                {
                    move_down(button);
                }
                if ((button.Location.X > 815) && (button.Location.Y == 520))
                {
                    move_left(button);
                }
                if ((button.Location.X == 815) && (button.Location.Y > 360))
                {
                    move_up(button);
                }
                //Station 4
                if ((button.Location.X == 535) && (button.Location.Y > 359) && (button.Location.Y < 520) && (E41.Value == false) && (S40.Value))
                {
                    move_down(button);
                }
                if ((button.Location.X > 395) && (button.Location.Y == 520))
                {
                    move_left(button);
                }
                if ((button.Location.X == 395) && (button.Location.Y > 360))
                {
                    move_up(button);
                }
                //Normal Movement
                if ((button.Location.Y == 230) && (button.Location.X < 450))
                {
                    move_right(button);
                }
                if ((button.Location.Y == 230) && (button.Location.X >= 450) && (button.Location.X < 550) && (!E114.Value))
                {
                    move_right(button);
                }
                if ((button.Location.Y == 230) && (button.Location.X < 1100) && (button.Location.X >= 550))
                {
                    move_right(button);
                }

                if ((button.Location.Y < 360) && (button.Location.X == 1100))
                {
                    move_down(button);
                }
                if ((button.Location.Y == 360) && (button.Location.X > 280))
                {
                    move_left(button);
                }
                if ((button.Location.X == 280) && (button.Location.Y > 230))
                {
                    move_up(button);
                }
            }
        }


        /*-Speed_AfterChangeValue-------------------------------------------------/
        *                                                                         /
        * Modification de la vitesse de l'animation.                              /
        *                                                                         /
        *------------------------------------------------------------------------*/
        private void Speed_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            timer1.Interval = Convert.ToInt32(Speed.Value * 10);
        }
        /*-button2_Click----------------------------------------------------------/
        *                                                                         /
        * Bouton Spawn.                                                           /
        *                                                                         /
        *------------------------------------------------------------------------*/
        private void button2_Click(object sender, EventArgs e)
        {
            spawn();
            label11.Text = buttonslist.Count().ToString();

        }
        /*-Spawn------------------------------------------------------------------/
         * 
         * Ajoute une palette au système, en ajoutant un bouton dont l'icone 
         * est une image de la palette.
         * 
         * La palette est aussi ajoutée à une liste de boutons permettant l'ajout 
         * et la suppression de la dernière palette ajoutée.
         * 
         *------------------------------------------------------------------------*/
        public Button spawn()
        {
            Button palletx = new Button();
            this.Controls.Add(palletx);
            this.Controls.SetChildIndex(palletx, 0);
            palletx.Location = new Point(280, 230);
            palletx.Size = new Size(50, 50);
            palletx.BackgroundImage = global::Monitoring.Properties.Resources.pallet1;
            palletx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            palletx.Enabled = false;
            palletx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonslist.Add(palletx);
            return (palletx);
        }
        /*-Menu_Button_Click-----------------------------------------------------/
        *                                                                        
        * Retour au menu principal                                                       
        *                                                                        
        *------------------------------------------------------------------------*/
        private void Menu_Button_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        /*-label2_Click-----------------------------------------------------/
        *                                                                        
        * Station 1 Indiv                                                     
        *                                                                        
        *------------------------------------------------------------------------*/

        private void label2_Click(object sender, EventArgs e)
        {
            Station1 test = new Station1();
            test.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        /*-Si0_StateChanged-----------------------------------------------------/
        *                                                                        
        * Enable station i                                                   
        *                                                                        
        *------------------------------------------------------------------------*/
        private void S10_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            S1Status.WriteValue(S10.Value);
        }

        private void S20_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            S2Status.WriteValue(S20.Value);
        }

        private void S40_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            S4Status.WriteValue(S40.Value);
        }

        private void S30_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            S3Status.WriteValue(S30.Value);
        }
        /*-Despawn----------------------------------------------------------------/
        *                                                                         /
        * Enlève une palette du système, en ajoutant un bouton dont l'icone       /
        * est une image de la palette.                                            /
        *                                                                         /
        *------------------------------------------------------------------------*/
        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonslist.Count() > 0)
            {
                buttonslist[buttonslist.Count() - 1].Hide();
                buttonslist.RemoveAt(buttonslist.Count() - 1);
                label11.Text = buttonslist.Count().ToString();
            }
            else
            {
                MessageBox.Show("No more Pallets to remove !", "No More Pallets To Remove !");
            }

        }
    }
}