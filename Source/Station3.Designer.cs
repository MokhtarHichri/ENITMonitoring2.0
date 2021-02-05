namespace Testing_Value_8Bit
{
    partial class Station3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding networkVariableBinding1 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding();
            NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding networkVariableBinding2 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding();
            this.ledArray1 = new NationalInstruments.UI.WindowsForms.LedArray();
            this.switchArray1 = new NationalInstruments.UI.WindowsForms.SwitchArray();
            this.led1 = new NationalInstruments.UI.WindowsForms.Led();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.networkVariableDataSource1 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Menu_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ledArray1.ItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchArray1.ItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkVariableDataSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ledArray1
            // 
            // 
            // 
            // 
            this.ledArray1.ItemTemplate.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.ledArray1.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.ledArray1.ItemTemplate.Name = "";
            this.ledArray1.ItemTemplate.OffColor = System.Drawing.Color.Teal;
            this.ledArray1.ItemTemplate.OnColor = System.Drawing.Color.Aqua;
            this.ledArray1.ItemTemplate.Size = new System.Drawing.Size(48, 48);
            this.ledArray1.ItemTemplate.TabIndex = 0;
            this.ledArray1.ItemTemplate.TabStop = false;
            this.ledArray1.LayoutMode = NationalInstruments.UI.ControlArrayLayoutMode.Horizontal;
            this.ledArray1.Location = new System.Drawing.Point(204, 117);
            this.ledArray1.Name = "ledArray1";
            this.ledArray1.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(16);
            this.ledArray1.Size = new System.Drawing.Size(786, 67);
            this.ledArray1.TabIndex = 0;
            // 
            // switchArray1
            // 
            // 
            // 
            // 
            this.switchArray1.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.switchArray1.ItemTemplate.Name = "";
            this.switchArray1.ItemTemplate.Size = new System.Drawing.Size(48, 80);
            this.switchArray1.ItemTemplate.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switchArray1.ItemTemplate.TabIndex = 0;
            this.switchArray1.ItemTemplate.TabStop = false;
            this.switchArray1.LayoutMode = NationalInstruments.UI.ControlArrayLayoutMode.Horizontal;
            this.switchArray1.Location = new System.Drawing.Point(200, 202);
            this.switchArray1.Name = "switchArray1";
            this.switchArray1.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(16);
            this.switchArray1.Size = new System.Drawing.Size(790, 99);
            this.switchArray1.TabIndex = 1;
            this.switchArray1.ValuesChanged += new System.EventHandler(this.switchArray1_ValuesChanged);
            // 
            // led1
            // 
            this.led1.BlinkMode = NationalInstruments.UI.LedBlinkMode.BlinkWhenOn;
            this.led1.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led1.Location = new System.Drawing.Point(12, 12);
            this.led1.Name = "led1";
            this.led1.OffColor = System.Drawing.Color.Maroon;
            this.led1.OnColor = System.Drawing.Color.Red;
            this.led1.Size = new System.Drawing.Size(44, 39);
            this.led1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(62, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connection Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Station 3";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(33, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "System Overview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Station Output Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "System Input Status";
            // 
            // networkVariableDataSource1
            // 
            networkVariableBinding1.Location = "\\\\localhost\\Automate\\OPC\\Tester\\Sim\\Station_3\\3_Inputs";
            networkVariableBinding1.Name = "1In";
            networkVariableBinding2.BindingMode = NationalInstruments.NetworkVariable.NetworkVariableBindingMode.ReadWrite;
            networkVariableBinding2.Location = "\\\\localhost\\Automate\\OPC\\Tester\\Sim\\Station_3\\3_Outputs";
            networkVariableBinding2.Name = "1Out";
            this.networkVariableDataSource1.Bindings.AddRange(new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding[] {
            networkVariableBinding1,
            networkVariableBinding2});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "@NetworkVariableLocation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Location:";
            // 
            // Menu_Button
            // 
            this.Menu_Button.Location = new System.Drawing.Point(33, 262);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(147, 23);
            this.Menu_Button.TabIndex = 11;
            this.Menu_Button.Text = "Back To Main Menu";
            this.Menu_Button.UseVisualStyleBackColor = true;
            this.Menu_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "@NetworkVariableLocation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "@NetworkVariableLocation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(221, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 30);
            this.label9.TabIndex = 14;
            this.label9.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(948, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "15";
            // 
            // Station2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1002, 309);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Menu_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.switchArray1);
            this.Controls.Add(this.ledArray1);
            this.HelpButton = true;
            this.Name = "Station2";
            this.Text = "Station 3 Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ledArray1.ItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchArray1.ItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkVariableDataSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.LedArray ledArray1;
        private NationalInstruments.UI.WindowsForms.SwitchArray switchArray1;
        private NationalInstruments.UI.WindowsForms.Led led1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource networkVariableDataSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Menu_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

