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

Ceci est le code source du menu principal.
Pour plus d'informations, cliquez sur le bouton "Help" ou consultez le fichier readme.pdf se trouvant au path du projet.

*/
using System;
using System.Diagnostics;
using System.Windows.Forms;
using NationalInstruments.NetworkVariable;

namespace Testing_Value_8Bit
{
    public partial class menu : Form
    {
        private NetworkVariableReader<bool> Overall_Status;
        private NetworkVariableWriter<bool> EmergencyStop;
        private NetworkVariableReader<bool> Station1Status;
        private NetworkVariableReader<bool> Station2Status;
        private NetworkVariableReader<bool> Station3Status;
        private NetworkVariableReader<bool> Station4Status; 
        private NetworkVariableSubscriber<bool> Station1_Status ;
        private NetworkVariableSubscriber<bool> Station2_Status;
        private NetworkVariableSubscriber<bool> Station3_Status;
        private NetworkVariableSubscriber<bool> Station4_Status;
        
        public menu()
        {
            InitializeComponent();
            ConnectOPCServer();
            
        }
        private void ConnectOPCServer()
        {
            Overall_Status = new NetworkVariableReader<bool>(networkVariableDataSource1.Bindings[0].Location);
            EmergencyStop = new NetworkVariableWriter<bool>(networkVariableDataSource1.Bindings[1].Location);
            Station1Status = new NetworkVariableReader<bool>(networkVariableDataSource1.Bindings[2].Location);
            Station2Status = new NetworkVariableReader<bool>(networkVariableDataSource1.Bindings[3].Location);
            Station3Status = new NetworkVariableReader<bool>(networkVariableDataSource1.Bindings[4].Location);
            Station4Status = new NetworkVariableReader<bool>(networkVariableDataSource1.Bindings[5].Location);
            Station1_Status = new NetworkVariableSubscriber<bool>(networkVariableDataSource1.Bindings[2].Location);
            Station2_Status = new NetworkVariableSubscriber<bool>(networkVariableDataSource1.Bindings[3].Location);
            Station3_Status = new NetworkVariableSubscriber<bool>(networkVariableDataSource1.Bindings[4].Location);
            Station4_Status = new NetworkVariableSubscriber<bool>(networkVariableDataSource1.Bindings[5].Location);
            
            
            
            
            //Handles
            Station1_Status.DataUpdated += new EventHandler<DataUpdatedEventArgs<bool>>(S1S);
            Station2_Status.DataUpdated += new EventHandler<DataUpdatedEventArgs<bool>>(S2S);
            Station3_Status.DataUpdated += new EventHandler<DataUpdatedEventArgs<bool>>(S3S);
            Station4_Status.DataUpdated += new EventHandler<DataUpdatedEventArgs<bool>>(S4S);


            //Connects

            Overall_Status.Connect();

            Station1Status.Connect();
            Station2Status.Connect();
            Station3Status.Connect();
            Station4Status.Connect();

            EmergencyStop.Connect();
            

            Station1_Status.Connect();
            Station2_Status.Connect();
            Station3_Status.Connect();
            Station4_Status.Connect();

            //System
            Sys_Status.Value = Convert.ToBoolean(Overall_Status.ReadData().GetValue());
            switch (Sys_Status.Value)
            {
                case true:
                    label7.Text = "Operational";
                    break;
                case false:
                    label7.Text = "Not Operational";
                    break;
            }
            
            //Station 1
            bool data = Station1Status.ReadData().GetValue();
            Station_1.Value = data;
            switch (Station_1.Value)
            {
                case true:
                    label8.Text = "Operational";
                    break;
                case false:
                    label8.Text = "Not Operational";
                    break;
            }
            //Station 2
             data = Station2Status.ReadData().GetValue();
            Station_2.Value = data;
            switch (Station_2.Value)
            {
                case true:
                    label9.Text = "Operational";
                    break;
                case false:
                    label9.Text = "Not Operational";
                    break;
            }
            //Station 3
             data = Station3Status.ReadData().GetValue();
            Station_3.Value = data;
            switch (Station_3.Value)
            {
                case true:
                    label10.Text = "Operational";
                    break;
                case false:
                    label10.Text = "Not Operational";
                    break;
            }

            //Station 4
            data = Station4Status.ReadData().GetValue();
            Station_4.Value = data;
            switch (Station_4.Value)
            {
                case true:
                    label11.Text = "Operational";
                    break;
                case false:
                    label11.Text = "Not Operational";
                    break;
            }

            Station1Status.Disconnect();
            Station2Status.Disconnect();
            Station3Status.Disconnect();
            Station4Status.Disconnect();

        }
        //Handles S1 New Data
        private void S1S(object Sender, DataUpdatedEventArgs<bool> e)
        {
            if (e.Data.HasValue)
            {
                bool data = e.Data.GetValue();
                Station_1.Value = data;
            switch (Station_1.Value)
                {
                    case true:
                        label8.Text = "Operational";
                        break;
                    case false:
                        label8.Text = "Not Operational";
                        break;
                }
            }
        }
        //Handles S2 New Data
        private void S2S(object Sender, DataUpdatedEventArgs<bool> e)
        {
            if (e.Data.HasValue)
            {
                bool data = e.Data.GetValue();
                Station_2.Value = data;
                switch (Station_2.Value)
                {
                    case true:
                        label9.Text = "Operational";
                        break;
                    case false:
                        label9.Text = "Not Operational";
                        break;
                }
            }
        }
        //Handles S3 New Data
        private void S3S(object Sender, DataUpdatedEventArgs<bool> e)
        {
            if (e.Data.HasValue)
            {
                bool data = e.Data.GetValue();
                Station_3.Value = data;
                switch (Station_3.Value)
                {
                    case true:
                        label10.Text = "Operational";
                        break;
                    case false:
                        label10.Text = "Not Operational";
                        break;
                }
            }
        }
        //Handles S4 New Data
        private void S4S(object Sender, DataUpdatedEventArgs<bool> e)
        {
            if (e.Data.HasValue)
            {
                bool data = e.Data.GetValue();
                Station_4.Value = data;
                switch (Station_4.Value)
                {
                    case true:
                        label11.Text = "Operational";
                        break;
                    case false:
                        label11.Text = "Not Operational";
                        break;
                }
            }
        }
        //Open overview
        private void button5_Click(object sender, EventArgs e)
        {
            overview overview = new overview();
            overview.Show();
        }
        //Open Station 1
        private void button1_Click(object sender, EventArgs e)
        {
            Station1 station_1 = new Station1();
            station_1.Show();
        }
        //Open Station 2
        private void button2_Click(object sender, EventArgs e)
        {
            Station2 station_2 = new Station2();
            station_2.Show();
        }
        //Open Station 3
        private void button3_Click(object sender, EventArgs e)
        {
            Station3 station_3 = new Station3();
            station_3.Show();
        }
        //Open Station 4
        private void button4_Click(object sender, EventArgs e)
        {
            Station4 station_4 = new Station4();
            station_4.Show();
        }
        //Emergency Stop
        private void button8_Click(object sender, EventArgs e)
        {
            EmergencyStop.WriteValue(true);
        }
        //Reprise du système
        private void button9_Click(object sender, EventArgs e)
        {
            EmergencyStop.WriteValue(false);
        }

        //Open Help pdf
        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/Readme.pdf");
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button9.Enabled = false;
                button8.Enabled = false;
            }
            else
            {
                button9.Enabled = true;
                button8.Enabled = true;
            }
        }
    }
}
