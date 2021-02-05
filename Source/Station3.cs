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

Ceci est le code source de l'interface de supervision de la station 3.

Pour plus d'informations, cliquez sur le bouton "Help" ou consultez le fichier readme.pdf se trouvant au path du projet.
*/
using NationalInstruments.NetworkVariable;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Testing_Value_8Bit
{

    public partial class Station3 : Form
    {
        public NetworkVariableSubscriber<UInt16> inputsub;
        public NetworkVariableSubscriber<UInt16> outputsub;
        private NetworkVariableReader<UInt16> readerinput;
        private NetworkVariableReader<UInt16> readeroutput;
        private NetworkVariableWriter<UInt16> buffwriter;
        private UInt16 buffreader;
        private string boolreader;
        public Station3()
        {

            InitializeComponent();
            ConnectOPCServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            NetworkVariableData<UInt16> opcdata = null;

            /* Initialiser la fenêtre avec les valeurs actuelles du serveur
             * 
             * readerinput: Entrées
             * Readeroutput: Sorties
             * 
             */
            opcdata = readerinput.ReadData();
            buffreader = opcdata.GetValue();
            boolreader = Convert.ToString(buffreader, 2);
            bool[] boolarray = new bool[17];
            boolarray = boolreader.Select(c => c == '1').ToArray();
            ledArray1.SetValues(boolarray);

            opcdata = readeroutput.ReadData();
            buffreader = opcdata.GetValue();
            boolreader = Convert.ToString(buffreader, 2);
            boolarray = boolreader.Select(c => c == '1').ToArray();
            switchArray1.SetValues(boolarray);
            label7.Text = networkVariableDataSource1.Bindings[0].Location;
            label8.Text = networkVariableDataSource1.Bindings[0].Location;
            NewValue();

        }
        private void ConnectOPCServer()
        {
            readerinput = new NetworkVariableReader<UInt16>(networkVariableDataSource1.Bindings[0].Location);
            readeroutput = new NetworkVariableReader<UInt16>(networkVariableDataSource1.Bindings[1].Location);
            buffwriter = new NetworkVariableWriter<UInt16>(networkVariableDataSource1.Bindings[1].Location);
            readerinput.Connect();
            buffwriter.Connect();
            readeroutput.Connect();
            label5.Text = networkVariableDataSource1.Bindings[0].Location;
            led1.Value = Convert.ToBoolean(readerinput.ConnectionStatus);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            NetworkVariableData<UInt16> opcdata = null;
            try
            {
                opcdata = readerinput.ReadData();
                buffreader = opcdata.GetValue();
                boolreader = Convert.ToString(buffreader, 2);
                bool[] boolarray = new bool[17];
                boolarray = boolreader.Select(c => c == '1').ToArray();
                ledArray1.SetValues(boolarray);
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Read Timeout", "Timeout");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            menu test = new menu();
            test.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            overview overview = new overview();
            overview.ShowDialog();
        }

        private void switchArray1_ValuesChanged(object sender, EventArgs e)
        {
            bool[] boolarray = switchArray1.GetValues();
            BitArray arr = new BitArray(boolarray);
            byte[] data = new byte[2];
            arr.CopyTo(data, 0);
            buffwriter.WriteValue(BitConverter.ToUInt16(data, 0));
        }
        private void NewValue()
        {
            inputsub = new NetworkVariableSubscriber<UInt16>(networkVariableDataSource1.Bindings[0].Location);
            inputsub.DataUpdated += new EventHandler<DataUpdatedEventArgs<UInt16>>(DataUp);
            inputsub.Connect();
        }
        private void DataUp(object Sender, DataUpdatedEventArgs<UInt16> e)
        {
            if (e.Data.HasTimeStamp)
            {
                label6.Text = "Timestamp: ";
                label5.Text = e.Data.TimeStamp.ToLocalTime().ToString();
                label5.Location = new Point(135, label5.Location.Y);
            }
            if (e.Data.HasValue)
            {
                UInt16 data = e.Data.GetValue();
                boolreader = Convert.ToString(data, 2);
                bool[] boolarray = new bool[17];
                boolarray = boolreader.Select(c => c == '1').ToArray();
                ledArray1.SetValues(boolarray);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
