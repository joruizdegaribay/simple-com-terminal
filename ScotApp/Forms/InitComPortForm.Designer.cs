namespace ScotApp.Forms
{
    partial class InitComPortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitComPortForm));
            this.lPortName = new System.Windows.Forms.Label();
            this.lBaudRate = new System.Windows.Forms.Label();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.gbDataBits = new System.Windows.Forms.GroupBox();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.gbStopBits = new System.Windows.Forms.GroupBox();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.gbParity = new System.Windows.Forms.GroupBox();
            this.rbOdd = new System.Windows.Forms.RadioButton();
            this.rbEven = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.gbDataBits.SuspendLayout();
            this.gbStopBits.SuspendLayout();
            this.gbParity.SuspendLayout();
            this.SuspendLayout();
            // 
            // lPortName
            // 
            this.lPortName.AutoSize = true;
            this.lPortName.Location = new System.Drawing.Point(29, 25);
            this.lPortName.Name = "lPortName";
            this.lPortName.Size = new System.Drawing.Size(64, 15);
            this.lPortName.TabIndex = 1;
            this.lPortName.Text = "Port name";
            // 
            // lBaudRate
            // 
            this.lBaudRate.AutoSize = true;
            this.lBaudRate.Location = new System.Drawing.Point(149, 25);
            this.lBaudRate.Name = "lBaudRate";
            this.lBaudRate.Size = new System.Drawing.Size(65, 15);
            this.lBaudRate.TabIndex = 3;
            this.lBaudRate.Text = "Baud Rate";
            // 
            // cbPortName
            // 
            this.cbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(29, 43);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(90, 23);
            this.cbPortName.Sorted = true;
            this.cbPortName.TabIndex = 2;
            this.cbPortName.SelectedIndexChanged += new System.EventHandler(this.cbPortName_SelectedIndexChanged);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "75",
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(149, 43);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(90, 23);
            this.cbBaudRate.TabIndex = 4;
            // 
            // gbDataBits
            // 
            this.gbDataBits.Controls.Add(this.rb7);
            this.gbDataBits.Controls.Add(this.rb8);
            this.gbDataBits.Controls.Add(this.rb6);
            this.gbDataBits.Location = new System.Drawing.Point(29, 77);
            this.gbDataBits.Name = "gbDataBits";
            this.gbDataBits.Size = new System.Drawing.Size(190, 50);
            this.gbDataBits.TabIndex = 5;
            this.gbDataBits.TabStop = false;
            this.gbDataBits.Text = "Data Bits";
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(80, 20);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(32, 19);
            this.rb7.TabIndex = 1;
            this.rb7.TabStop = true;
            this.rb7.Text = "7";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(130, 20);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(32, 19);
            this.rb8.TabIndex = 2;
            this.rb8.TabStop = true;
            this.rb8.Text = "8";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(30, 20);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(32, 19);
            this.rb6.TabIndex = 0;
            this.rb6.TabStop = true;
            this.rb6.Text = "6";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // gbStopBits
            // 
            this.gbStopBits.Controls.Add(this.rb15);
            this.gbStopBits.Controls.Add(this.rb2);
            this.gbStopBits.Controls.Add(this.rb1);
            this.gbStopBits.Location = new System.Drawing.Point(29, 138);
            this.gbStopBits.Name = "gbStopBits";
            this.gbStopBits.Size = new System.Drawing.Size(190, 50);
            this.gbStopBits.TabIndex = 6;
            this.gbStopBits.TabStop = false;
            this.gbStopBits.Text = "Stop Bits";
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Location = new System.Drawing.Point(80, 20);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(42, 19);
            this.rb15.TabIndex = 1;
            this.rb15.TabStop = true;
            this.rb15.Text = "1.5";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(130, 20);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(32, 19);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(30, 20);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(32, 19);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // gbParity
            // 
            this.gbParity.Controls.Add(this.rbOdd);
            this.gbParity.Controls.Add(this.rbEven);
            this.gbParity.Controls.Add(this.rbNone);
            this.gbParity.Location = new System.Drawing.Point(235, 77);
            this.gbParity.Name = "gbParity";
            this.gbParity.Size = new System.Drawing.Size(120, 111);
            this.gbParity.TabIndex = 7;
            this.gbParity.TabStop = false;
            this.gbParity.Text = "Parity";
            // 
            // rbOdd
            // 
            this.rbOdd.AutoSize = true;
            this.rbOdd.Location = new System.Drawing.Point(30, 50);
            this.rbOdd.Name = "rbOdd";
            this.rbOdd.Size = new System.Drawing.Size(48, 19);
            this.rbOdd.TabIndex = 1;
            this.rbOdd.TabStop = true;
            this.rbOdd.Text = "Odd";
            this.rbOdd.UseVisualStyleBackColor = true;
            // 
            // rbEven
            // 
            this.rbEven.AutoSize = true;
            this.rbEven.Location = new System.Drawing.Point(30, 75);
            this.rbEven.Name = "rbEven";
            this.rbEven.Size = new System.Drawing.Size(52, 19);
            this.rbEven.TabIndex = 2;
            this.rbEven.TabStop = true;
            this.rbEven.Text = "Even";
            this.rbEven.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(30, 25);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(55, 19);
            this.rbNone.TabIndex = 0;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Location = new System.Drawing.Point(292, 214);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(80, 26);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOpen
            // 
            this.bOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOpen.Enabled = false;
            this.bOpen.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpen.Location = new System.Drawing.Point(206, 214);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(80, 26);
            this.bOpen.TabIndex = 8;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // InitComPortForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(384, 252);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.gbParity);
            this.Controls.Add(this.gbStopBits);
            this.Controls.Add(this.gbDataBits);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbPortName);
            this.Controls.Add(this.lBaudRate);
            this.Controls.Add(this.lPortName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitComPortForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open COM Port";
            this.Load += new System.EventHandler(this.InitComPortForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InitComPortForm_KeyDown);
            this.gbDataBits.ResumeLayout(false);
            this.gbDataBits.PerformLayout();
            this.gbStopBits.ResumeLayout(false);
            this.gbStopBits.PerformLayout();
            this.gbParity.ResumeLayout(false);
            this.gbParity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPortName;
        private System.Windows.Forms.Label lBaudRate;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.GroupBox gbDataBits;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.GroupBox gbStopBits;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox gbParity;
        private System.Windows.Forms.RadioButton rbOdd;
        private System.Windows.Forms.RadioButton rbEven;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOpen;
    }
}