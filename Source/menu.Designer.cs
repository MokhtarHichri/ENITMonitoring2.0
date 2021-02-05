namespace Testing_Value_8Bit
{
    partial class menu
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
            NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding networkVariableBinding3 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding();
            NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding networkVariableBinding4 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding();
            NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding networkVariableBinding5 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding();
            NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding networkVariableBinding6 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Sys_Status = new NationalInstruments.UI.WindowsForms.Led();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Station_1 = new NationalInstruments.UI.WindowsForms.Led();
            this.Station_2 = new NationalInstruments.UI.WindowsForms.Led();
            this.Station_3 = new NationalInstruments.UI.WindowsForms.Led();
            this.Station_4 = new NationalInstruments.UI.WindowsForms.Led();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.networkVariableDataSource1 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sys_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Station_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Station_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Station_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Station_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkVariableDataSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Station 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flexible Cell Monitoring System 2.0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Station 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Station 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(59, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Station 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(343, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "System Overview";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Sys_Status
            // 
            this.Sys_Status.BlinkMode = NationalInstruments.UI.LedBlinkMode.BlinkWhenOn;
            this.Sys_Status.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.Sys_Status.Location = new System.Drawing.Point(17, 42);
            this.Sys_Status.Name = "Sys_Status";
            this.Sys_Status.Size = new System.Drawing.Size(33, 32);
            this.Sys_Status.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // Station_1
            // 
            this.Station_1.LedStyle = NationalInstruments.UI.LedStyle.Square3D;
            this.Station_1.Location = new System.Drawing.Point(29, 110);
            this.Station_1.Name = "Station_1";
            this.Station_1.OffColor = System.Drawing.Color.Maroon;
            this.Station_1.OnColor = System.Drawing.Color.Red;
            this.Station_1.Size = new System.Drawing.Size(24, 23);
            this.Station_1.TabIndex = 11;
            // 
            // Station_2
            // 
            this.Station_2.LedStyle = NationalInstruments.UI.LedStyle.Square3D;
            this.Station_2.Location = new System.Drawing.Point(29, 139);
            this.Station_2.Name = "Station_2";
            this.Station_2.OffColor = System.Drawing.Color.Maroon;
            this.Station_2.OnColor = System.Drawing.Color.Red;
            this.Station_2.Size = new System.Drawing.Size(24, 23);
            this.Station_2.TabIndex = 12;
            // 
            // Station_3
            // 
            this.Station_3.LedStyle = NationalInstruments.UI.LedStyle.Square3D;
            this.Station_3.Location = new System.Drawing.Point(29, 167);
            this.Station_3.Name = "Station_3";
            this.Station_3.OffColor = System.Drawing.Color.Maroon;
            this.Station_3.OnColor = System.Drawing.Color.Red;
            this.Station_3.Size = new System.Drawing.Size(24, 23);
            this.Station_3.TabIndex = 13;
            // 
            // Station_4
            // 
            this.Station_4.LedStyle = NationalInstruments.UI.LedStyle.Square3D;
            this.Station_4.Location = new System.Drawing.Point(29, 196);
            this.Station_4.Name = "Station_4";
            this.Station_4.OffColor = System.Drawing.Color.Maroon;
            this.Station_4.OnColor = System.Drawing.Color.Red;
            this.Station_4.Size = new System.Drawing.Size(24, 23);
            this.Station_4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "System is:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Operational/Not Operational";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(366, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Help";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(366, 110);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 106);
            this.button8.TabIndex = 19;
            this.button8.Text = "EMERGENCY SHUTDOWN";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lime;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(366, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "Restart";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Operational/Not Operational";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(201, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Operational/Not Operational";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Operational/Not Operational";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(201, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Operational/Not Operational";
            // 
            // networkVariableDataSource1
            // 
            networkVariableBinding1.BindingMode = NationalInstruments.NetworkVariable.NetworkVariableBindingMode.ReadWrite;
            networkVariableBinding1.Location = "\\\\localhost\\Automate\\OPC\\Tester\\Sim\\Status";
            networkVariableBinding1.Name = "Status";
            networkVariableBinding2.BindingMode = NationalInstruments.NetworkVariable.NetworkVariableBindingMode.ReadWrite;
            networkVariableBinding2.Location = "\\\\localhost\\Automate\\OPC\\Tester\\Sim\\Emergency";
            networkVariableBinding2.Name = "Emergency";
            networkVariableBinding3.BindingMode = NationalInstruments.NetworkVariable.NetworkVariableBindingMode.ReadWrite;
            networkVariableBinding3.Location = "\\\\localhost\\Automate\\OPC\\Tester\\Sim\\Station_1\\Status";
            networkVariableBinding3.Name = "Station1_Status";
            networkVariableBinding4.BindingMode = NationalInstruments.NetworkVariable.NetworkVariableBindingMode.ReadWrite;
            networkVariableBinding4.Location = "\\\\localhost\\Automate\\OPC\\Tester\\Sim\\Station_2\\Status";
            networkVariableBinding4.Name = "Station2_Status";
            networkVariableBinding5.Location = "\\\\localhost\\Automate\\OPC\\Tester\\Sim\\Station_3\\Status";
            networkVariableBinding5.Name = "Station3_Status";
            networkVariableBinding6.Location = "\\\\localhost\\Automate\\OPC\\Tester\\Sim\\Station_4\\Status";
            networkVariableBinding6.Name = "Station4_Status";
            this.networkVariableDataSource1.Bindings.AddRange(new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding[] {
            networkVariableBinding1,
            networkVariableBinding2,
            networkVariableBinding3,
            networkVariableBinding4,
            networkVariableBinding5,
            networkVariableBinding6});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(366, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Safe_Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 227);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Station_4);
            this.Controls.Add(this.Station_3);
            this.Controls.Add(this.Station_2);
            this.Controls.Add(this.Station_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sys_Status);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.Text = "Flexible Cell Monitoring System 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.Sys_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Station_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Station_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Station_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Station_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkVariableDataSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private NationalInstruments.UI.WindowsForms.Led Sys_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private NationalInstruments.UI.WindowsForms.Led Station_1;
        private NationalInstruments.UI.WindowsForms.Led Station_2;
        private NationalInstruments.UI.WindowsForms.Led Station_3;
        private NationalInstruments.UI.WindowsForms.Led Station_4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource networkVariableDataSource1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}