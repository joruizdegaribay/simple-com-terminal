namespace ScotApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.miCloseConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAsConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.miPrintTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miComPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miClosePort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miDtr = new System.Windows.Forms.ToolStripMenuItem();
            this.miRts = new System.Windows.Forms.ToolStripMenuItem();
            this.miPushKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPushKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePushKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miSendKey1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendKey2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendKey3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendKey4 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendKey5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendKey6 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendKey7 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendKey8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miSetPushKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.bSetPushKeys = new System.Windows.Forms.Button();
            this.bSendKey8 = new System.Windows.Forms.Button();
            this.bSendKey2 = new System.Windows.Forms.Button();
            this.bSendKey3 = new System.Windows.Forms.Button();
            this.bSendKey4 = new System.Windows.Forms.Button();
            this.bSendKey5 = new System.Windows.Forms.Button();
            this.bSendKey6 = new System.Windows.Forms.Button();
            this.bSendKey7 = new System.Windows.Forms.Button();
            this.bSendKey1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bSendMessage = new System.Windows.Forms.Button();
            this.bClearTerminal = new System.Windows.Forms.Button();
            this.bPrintTerminal = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lHelpMessage = new System.Windows.Forms.Label();
            this.gbKeys = new System.Windows.Forms.GroupBox();
            this.gbSendMessage = new System.Windows.Forms.GroupBox();
            this.gbTerminal = new System.Windows.Forms.GroupBox();
            this.pHexLog = new System.Windows.Forms.Panel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbNonAscii = new System.Windows.Forms.RadioButton();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTerminal = new System.Windows.Forms.TextBox();
            this.cbLocalEcho = new System.Windows.Forms.CheckBox();
            this.gBSignals = new System.Windows.Forms.GroupBox();
            this.cbRts = new System.Windows.Forms.CheckBox();
            this.cbDtr = new System.Windows.Forms.CheckBox();
            this.lState = new System.Windows.Forms.Label();
            this.openKeysFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveKeysFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.gbKeys.SuspendLayout();
            this.gbSendMessage.SuspendLayout();
            this.gbTerminal.SuspendLayout();
            this.pHexLog.SuspendLayout();
            this.gBSignals.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConnection,
            this.miComPort,
            this.miPushKeys,
            this.miHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miConnection
            // 
            this.miConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewConnection,
            this.miOpenConnection,
            this.miCloseConnection,
            this.miSaveConnection,
            this.miSaveAsConnection,
            this.toolStripSeparator7,
            this.miPrintTerminal,
            this.toolStripSeparator5,
            this.miExit});
            this.miConnection.Name = "miConnection";
            this.miConnection.Size = new System.Drawing.Size(81, 20);
            this.miConnection.Text = "Connection";
            // 
            // miNewConnection
            // 
            this.miNewConnection.Enabled = false;
            this.miNewConnection.Name = "miNewConnection";
            this.miNewConnection.Size = new System.Drawing.Size(121, 22);
            this.miNewConnection.Text = "New";
            this.miNewConnection.Visible = false;
            this.miNewConnection.Click += new System.EventHandler(this.miNewConnection_Click);
            // 
            // miOpenConnection
            // 
            this.miOpenConnection.Enabled = false;
            this.miOpenConnection.Name = "miOpenConnection";
            this.miOpenConnection.Size = new System.Drawing.Size(121, 22);
            this.miOpenConnection.Text = "Open...";
            this.miOpenConnection.Visible = false;
            this.miOpenConnection.Click += new System.EventHandler(this.miOpenConnection_Click);
            // 
            // miCloseConnection
            // 
            this.miCloseConnection.Enabled = false;
            this.miCloseConnection.Name = "miCloseConnection";
            this.miCloseConnection.Size = new System.Drawing.Size(121, 22);
            this.miCloseConnection.Text = "Close";
            this.miCloseConnection.Visible = false;
            this.miCloseConnection.Click += new System.EventHandler(this.miCloseConnection_Click);
            // 
            // miSaveConnection
            // 
            this.miSaveConnection.Enabled = false;
            this.miSaveConnection.Name = "miSaveConnection";
            this.miSaveConnection.Size = new System.Drawing.Size(121, 22);
            this.miSaveConnection.Text = "Save";
            this.miSaveConnection.Visible = false;
            this.miSaveConnection.Click += new System.EventHandler(this.miSaveConnection_Click);
            // 
            // miSaveAsConnection
            // 
            this.miSaveAsConnection.Enabled = false;
            this.miSaveAsConnection.Name = "miSaveAsConnection";
            this.miSaveAsConnection.Size = new System.Drawing.Size(121, 22);
            this.miSaveAsConnection.Text = "Save as...";
            this.miSaveAsConnection.Visible = false;
            this.miSaveAsConnection.Click += new System.EventHandler(this.miSaveAsConnection_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(118, 6);
            this.toolStripSeparator7.Visible = false;
            // 
            // miPrintTerminal
            // 
            this.miPrintTerminal.Name = "miPrintTerminal";
            this.miPrintTerminal.Size = new System.Drawing.Size(121, 22);
            this.miPrintTerminal.Text = "Print";
            this.miPrintTerminal.Click += new System.EventHandler(this.miPrintTerminal_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(118, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(121, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miComPort
            // 
            this.miComPort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenPort,
            this.miClosePort,
            this.toolStripSeparator4,
            this.miDtr,
            this.miRts});
            this.miComPort.Name = "miComPort";
            this.miComPort.Size = new System.Drawing.Size(67, 20);
            this.miComPort.Text = "ComPort";
            // 
            // miOpenPort
            // 
            this.miOpenPort.Name = "miOpenPort";
            this.miOpenPort.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miOpenPort.Size = new System.Drawing.Size(122, 22);
            this.miOpenPort.Text = "Open";
            this.miOpenPort.Click += new System.EventHandler(this.miOpenPort_Click);
            // 
            // miClosePort
            // 
            this.miClosePort.Enabled = false;
            this.miClosePort.Name = "miClosePort";
            this.miClosePort.Size = new System.Drawing.Size(122, 22);
            this.miClosePort.Text = "Close";
            this.miClosePort.Click += new System.EventHandler(this.miClosePort_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(119, 6);
            // 
            // miDtr
            // 
            this.miDtr.Enabled = false;
            this.miDtr.Name = "miDtr";
            this.miDtr.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.miDtr.Size = new System.Drawing.Size(122, 22);
            this.miDtr.Text = "DTR";
            this.miDtr.Click += new System.EventHandler(this.miDtr_Click);
            // 
            // miRts
            // 
            this.miRts.Enabled = false;
            this.miRts.Name = "miRts";
            this.miRts.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.miRts.Size = new System.Drawing.Size(122, 22);
            this.miRts.Text = "RTS";
            this.miRts.Click += new System.EventHandler(this.miRts_Click);
            // 
            // miPushKeys
            // 
            this.miPushKeys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPushKeysToolStripMenuItem,
            this.savePushKeysToolStripMenuItem,
            this.toolStripSeparator2,
            this.miSendKey1,
            this.miSendKey2,
            this.miSendKey3,
            this.miSendKey4,
            this.miSendKey5,
            this.miSendKey6,
            this.miSendKey7,
            this.miSendKey8,
            this.toolStripSeparator1,
            this.miSetPushKeys});
            this.miPushKeys.Name = "miPushKeys";
            this.miPushKeys.Size = new System.Drawing.Size(43, 20);
            this.miPushKeys.Text = "Keys";
            // 
            // loadPushKeysToolStripMenuItem
            // 
            this.loadPushKeysToolStripMenuItem.Name = "loadPushKeysToolStripMenuItem";
            this.loadPushKeysToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.loadPushKeysToolStripMenuItem.Text = "Load Push Keys";
            this.loadPushKeysToolStripMenuItem.Click += new System.EventHandler(this.loadPushKeysToolStripMenuItem_Click);
            // 
            // savePushKeysToolStripMenuItem
            // 
            this.savePushKeysToolStripMenuItem.Name = "savePushKeysToolStripMenuItem";
            this.savePushKeysToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.savePushKeysToolStripMenuItem.Text = "Save Push Keys";
            this.savePushKeysToolStripMenuItem.Click += new System.EventHandler(this.savePushKeysToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // miSendKey1
            // 
            this.miSendKey1.Enabled = false;
            this.miSendKey1.Name = "miSendKey1";
            this.miSendKey1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.miSendKey1.Size = new System.Drawing.Size(167, 22);
            this.miSendKey1.Text = "Send Key 1";
            this.miSendKey1.Click += new System.EventHandler(this.miSendKey1_Click);
            // 
            // miSendKey2
            // 
            this.miSendKey2.Enabled = false;
            this.miSendKey2.Name = "miSendKey2";
            this.miSendKey2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.miSendKey2.Size = new System.Drawing.Size(167, 22);
            this.miSendKey2.Text = "Send Key 2";
            this.miSendKey2.Click += new System.EventHandler(this.miSendKey2_Click);
            // 
            // miSendKey3
            // 
            this.miSendKey3.Enabled = false;
            this.miSendKey3.Name = "miSendKey3";
            this.miSendKey3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.miSendKey3.Size = new System.Drawing.Size(167, 22);
            this.miSendKey3.Text = "Send Key 3";
            this.miSendKey3.Click += new System.EventHandler(this.miSendKey3_Click);
            // 
            // miSendKey4
            // 
            this.miSendKey4.Enabled = false;
            this.miSendKey4.Name = "miSendKey4";
            this.miSendKey4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.miSendKey4.Size = new System.Drawing.Size(167, 22);
            this.miSendKey4.Text = "Send Key 4";
            this.miSendKey4.Click += new System.EventHandler(this.miSendKey4_Click);
            // 
            // miSendKey5
            // 
            this.miSendKey5.Enabled = false;
            this.miSendKey5.Name = "miSendKey5";
            this.miSendKey5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.miSendKey5.Size = new System.Drawing.Size(167, 22);
            this.miSendKey5.Text = "Send Key 5";
            this.miSendKey5.Click += new System.EventHandler(this.miSendKey5_Click);
            // 
            // miSendKey6
            // 
            this.miSendKey6.Enabled = false;
            this.miSendKey6.Name = "miSendKey6";
            this.miSendKey6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D6)));
            this.miSendKey6.Size = new System.Drawing.Size(167, 22);
            this.miSendKey6.Text = "Send Key 6";
            this.miSendKey6.Click += new System.EventHandler(this.miSendKey6_Click);
            // 
            // miSendKey7
            // 
            this.miSendKey7.Enabled = false;
            this.miSendKey7.Name = "miSendKey7";
            this.miSendKey7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D7)));
            this.miSendKey7.Size = new System.Drawing.Size(167, 22);
            this.miSendKey7.Text = "Send Key 7";
            this.miSendKey7.Click += new System.EventHandler(this.miSendKey7_Click);
            // 
            // miSendKey8
            // 
            this.miSendKey8.Enabled = false;
            this.miSendKey8.Name = "miSendKey8";
            this.miSendKey8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D8)));
            this.miSendKey8.Size = new System.Drawing.Size(167, 22);
            this.miSendKey8.Text = "Send Key 8";
            this.miSendKey8.Click += new System.EventHandler(this.miSendKey8_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // miSetPushKeys
            // 
            this.miSetPushKeys.Name = "miSetPushKeys";
            this.miSetPushKeys.Size = new System.Drawing.Size(167, 22);
            this.miSetPushKeys.Text = "Set Push Keys";
            this.miSetPushKeys.Click += new System.EventHandler(this.miSetPushKeys_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "Help";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(149, 22);
            this.miAbout.Text = "About SCOT...";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // bSetPushKeys
            // 
            this.bSetPushKeys.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSetPushKeys.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSetPushKeys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSetPushKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSetPushKeys.Location = new System.Drawing.Point(20, 298);
            this.bSetPushKeys.Name = "bSetPushKeys";
            this.bSetPushKeys.Size = new System.Drawing.Size(40, 26);
            this.bSetPushKeys.TabIndex = 8;
            this.bSetPushKeys.Text = "K=";
            this.toolTip.SetToolTip(this.bSetPushKeys, "Set Push Keys");
            this.bSetPushKeys.UseVisualStyleBackColor = true;
            this.bSetPushKeys.Click += new System.EventHandler(this.bSetPushKeys_Click);
            // 
            // bSendKey8
            // 
            this.bSendKey8.Enabled = false;
            this.bSendKey8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendKey8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendKey8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendKey8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendKey8.Location = new System.Drawing.Point(20, 265);
            this.bSendKey8.Name = "bSendKey8";
            this.bSendKey8.Size = new System.Drawing.Size(40, 26);
            this.bSendKey8.TabIndex = 7;
            this.bSendKey8.Text = "K8";
            this.bSendKey8.UseVisualStyleBackColor = true;
            this.bSendKey8.Click += new System.EventHandler(this.bSendKey8_Click);
            // 
            // bSendKey2
            // 
            this.bSendKey2.Enabled = false;
            this.bSendKey2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendKey2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendKey2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendKey2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendKey2.Location = new System.Drawing.Point(20, 64);
            this.bSendKey2.Name = "bSendKey2";
            this.bSendKey2.Size = new System.Drawing.Size(40, 26);
            this.bSendKey2.TabIndex = 1;
            this.bSendKey2.Text = "K2";
            this.bSendKey2.UseVisualStyleBackColor = true;
            this.bSendKey2.Click += new System.EventHandler(this.bSendKey2_Click);
            // 
            // bSendKey3
            // 
            this.bSendKey3.Enabled = false;
            this.bSendKey3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendKey3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendKey3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendKey3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendKey3.Location = new System.Drawing.Point(20, 97);
            this.bSendKey3.Name = "bSendKey3";
            this.bSendKey3.Size = new System.Drawing.Size(40, 26);
            this.bSendKey3.TabIndex = 2;
            this.bSendKey3.Text = "K3";
            this.bSendKey3.UseVisualStyleBackColor = true;
            this.bSendKey3.Click += new System.EventHandler(this.bSendKey3_Click);
            // 
            // bSendKey4
            // 
            this.bSendKey4.Enabled = false;
            this.bSendKey4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendKey4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendKey4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendKey4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendKey4.Location = new System.Drawing.Point(20, 131);
            this.bSendKey4.Name = "bSendKey4";
            this.bSendKey4.Size = new System.Drawing.Size(40, 26);
            this.bSendKey4.TabIndex = 3;
            this.bSendKey4.Text = "K4";
            this.bSendKey4.UseVisualStyleBackColor = true;
            this.bSendKey4.Click += new System.EventHandler(this.bSendKey4_Click);
            // 
            // bSendKey5
            // 
            this.bSendKey5.Enabled = false;
            this.bSendKey5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendKey5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendKey5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendKey5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendKey5.Location = new System.Drawing.Point(20, 164);
            this.bSendKey5.Name = "bSendKey5";
            this.bSendKey5.Size = new System.Drawing.Size(40, 26);
            this.bSendKey5.TabIndex = 4;
            this.bSendKey5.Text = "K5";
            this.bSendKey5.UseVisualStyleBackColor = true;
            this.bSendKey5.Click += new System.EventHandler(this.bSendKey5_Click);
            // 
            // bSendKey6
            // 
            this.bSendKey6.Enabled = false;
            this.bSendKey6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendKey6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendKey6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendKey6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendKey6.Location = new System.Drawing.Point(20, 198);
            this.bSendKey6.Name = "bSendKey6";
            this.bSendKey6.Size = new System.Drawing.Size(40, 26);
            this.bSendKey6.TabIndex = 5;
            this.bSendKey6.Text = "K6";
            this.bSendKey6.UseVisualStyleBackColor = true;
            this.bSendKey6.Click += new System.EventHandler(this.bSendKey6_Click);
            // 
            // bSendKey7
            // 
            this.bSendKey7.Enabled = false;
            this.bSendKey7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendKey7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendKey7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendKey7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendKey7.Location = new System.Drawing.Point(20, 231);
            this.bSendKey7.Name = "bSendKey7";
            this.bSendKey7.Size = new System.Drawing.Size(40, 26);
            this.bSendKey7.TabIndex = 6;
            this.bSendKey7.Text = "K7";
            this.bSendKey7.UseVisualStyleBackColor = true;
            this.bSendKey7.Click += new System.EventHandler(this.bSendKey7_Click);
            // 
            // bSendKey1
            // 
            this.bSendKey1.Enabled = false;
            this.bSendKey1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendKey1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendKey1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendKey1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendKey1.Location = new System.Drawing.Point(20, 30);
            this.bSendKey1.Name = "bSendKey1";
            this.bSendKey1.Size = new System.Drawing.Size(40, 26);
            this.bSendKey1.TabIndex = 0;
            this.bSendKey1.Text = "K1";
            this.bSendKey1.UseVisualStyleBackColor = true;
            this.bSendKey1.Click += new System.EventHandler(this.bSendKey1_Click);
            // 
            // bSendMessage
            // 
            this.bSendMessage.Enabled = false;
            this.bSendMessage.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSendMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bSendMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSendMessage.Location = new System.Drawing.Point(381, 27);
            this.bSendMessage.Name = "bSendMessage";
            this.bSendMessage.Size = new System.Drawing.Size(60, 26);
            this.bSendMessage.TabIndex = 2;
            this.bSendMessage.Text = "Send";
            this.toolTip.SetToolTip(this.bSendMessage, "Send message over serial port");
            this.bSendMessage.UseVisualStyleBackColor = true;
            this.bSendMessage.Click += new System.EventHandler(this.bSendMessage_Click);
            // 
            // bClearTerminal
            // 
            this.bClearTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClearTerminal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bClearTerminal.FlatAppearance.BorderSize = 0;
            this.bClearTerminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bClearTerminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bClearTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClearTerminal.Image = ((System.Drawing.Image)(resources.GetObject("bClearTerminal.Image")));
            this.bClearTerminal.Location = new System.Drawing.Point(593, 236);
            this.bClearTerminal.Name = "bClearTerminal";
            this.bClearTerminal.Size = new System.Drawing.Size(32, 30);
            this.bClearTerminal.TabIndex = 4;
            this.toolTip.SetToolTip(this.bClearTerminal, "Send message over serial port");
            this.bClearTerminal.UseVisualStyleBackColor = true;
            this.bClearTerminal.Click += new System.EventHandler(this.bClearTerminal_Click);
            // 
            // bPrintTerminal
            // 
            this.bPrintTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrintTerminal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bPrintTerminal.FlatAppearance.BorderSize = 0;
            this.bPrintTerminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.bPrintTerminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bPrintTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrintTerminal.Image = ((System.Drawing.Image)(resources.GetObject("bPrintTerminal.Image")));
            this.bPrintTerminal.Location = new System.Drawing.Point(555, 236);
            this.bPrintTerminal.Name = "bPrintTerminal";
            this.bPrintTerminal.Size = new System.Drawing.Size(32, 30);
            this.bPrintTerminal.TabIndex = 3;
            this.toolTip.SetToolTip(this.bPrintTerminal, "Send message over serial port");
            this.bPrintTerminal.UseVisualStyleBackColor = true;
            this.bPrintTerminal.Click += new System.EventHandler(this.bPrintTerminal_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(25, 30);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(350, 21);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // lHelpMessage
            // 
            this.lHelpMessage.AutoSize = true;
            this.lHelpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHelpMessage.Location = new System.Drawing.Point(25, 54);
            this.lHelpMessage.Name = "lHelpMessage";
            this.lHelpMessage.Size = new System.Drawing.Size(333, 13);
            this.lHelpMessage.TabIndex = 1;
            this.lHelpMessage.Text = "To enter hexadecimal values use the notation \"\\2-digit-hexadecimal\".";
            // 
            // gbKeys
            // 
            this.gbKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbKeys.Controls.Add(this.bSendKey1);
            this.gbKeys.Controls.Add(this.bSendKey6);
            this.gbKeys.Controls.Add(this.bSetPushKeys);
            this.gbKeys.Controls.Add(this.bSendKey7);
            this.gbKeys.Controls.Add(this.bSendKey5);
            this.gbKeys.Controls.Add(this.bSendKey4);
            this.gbKeys.Controls.Add(this.bSendKey8);
            this.gbKeys.Controls.Add(this.bSendKey3);
            this.gbKeys.Controls.Add(this.bSendKey2);
            this.gbKeys.Location = new System.Drawing.Point(20, 33);
            this.gbKeys.Name = "gbKeys";
            this.gbKeys.Size = new System.Drawing.Size(80, 390);
            this.gbKeys.TabIndex = 1;
            this.gbKeys.TabStop = false;
            this.gbKeys.Text = "Keys";
            // 
            // gbSendMessage
            // 
            this.gbSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSendMessage.Controls.Add(this.tbMessage);
            this.gbSendMessage.Controls.Add(this.bSendMessage);
            this.gbSendMessage.Controls.Add(this.lHelpMessage);
            this.gbSendMessage.Location = new System.Drawing.Point(230, 33);
            this.gbSendMessage.Name = "gbSendMessage";
            this.gbSendMessage.Size = new System.Drawing.Size(535, 80);
            this.gbSendMessage.TabIndex = 3;
            this.gbSendMessage.TabStop = false;
            this.gbSendMessage.Text = "Send Message";
            // 
            // gbTerminal
            // 
            this.gbTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTerminal.Controls.Add(this.pHexLog);
            this.gbTerminal.Controls.Add(this.bPrintTerminal);
            this.gbTerminal.Controls.Add(this.bClearTerminal);
            this.gbTerminal.Controls.Add(this.tbTerminal);
            this.gbTerminal.Controls.Add(this.cbLocalEcho);
            this.gbTerminal.Location = new System.Drawing.Point(115, 130);
            this.gbTerminal.Name = "gbTerminal";
            this.gbTerminal.Size = new System.Drawing.Size(650, 293);
            this.gbTerminal.TabIndex = 4;
            this.gbTerminal.TabStop = false;
            this.gbTerminal.Text = "Terminal";
            // 
            // pHexLog
            // 
            this.pHexLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pHexLog.Controls.Add(this.rbAll);
            this.pHexLog.Controls.Add(this.rbNonAscii);
            this.pHexLog.Controls.Add(this.rbOff);
            this.pHexLog.Controls.Add(this.label2);
            this.pHexLog.Location = new System.Drawing.Point(150, 236);
            this.pHexLog.Name = "pHexLog";
            this.pHexLog.Size = new System.Drawing.Size(200, 50);
            this.pHexLog.TabIndex = 2;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(150, 25);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(38, 19);
            this.rbAll.TabIndex = 3;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbNonAscii
            // 
            this.rbNonAscii.AutoSize = true;
            this.rbNonAscii.Location = new System.Drawing.Point(59, 25);
            this.rbNonAscii.Name = "rbNonAscii";
            this.rbNonAscii.Size = new System.Drawing.Size(85, 19);
            this.rbNonAscii.TabIndex = 2;
            this.rbNonAscii.TabStop = true;
            this.rbNonAscii.Text = "Non ASCCI";
            this.rbNonAscii.UseVisualStyleBackColor = true;
            this.rbNonAscii.CheckedChanged += new System.EventHandler(this.rbNonAscii_CheckedChanged);
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Location = new System.Drawing.Point(13, 25);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(40, 19);
            this.rbOff.TabIndex = 1;
            this.rbOff.TabStop = true;
            this.rbOff.Text = "Off";
            this.rbOff.UseVisualStyleBackColor = true;
            this.rbOff.CheckedChanged += new System.EventHandler(this.rbOff_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hex Log";
            // 
            // tbTerminal
            // 
            this.tbTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTerminal.BackColor = System.Drawing.SystemColors.Window;
            this.tbTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbTerminal.Location = new System.Drawing.Point(25, 30);
            this.tbTerminal.Multiline = true;
            this.tbTerminal.Name = "tbTerminal";
            this.tbTerminal.ReadOnly = true;
            this.tbTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTerminal.Size = new System.Drawing.Size(600, 200);
            this.tbTerminal.TabIndex = 0;
            // 
            // cbLocalEcho
            // 
            this.cbLocalEcho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbLocalEcho.AutoSize = true;
            this.cbLocalEcho.Location = new System.Drawing.Point(45, 237);
            this.cbLocalEcho.Name = "cbLocalEcho";
            this.cbLocalEcho.Size = new System.Drawing.Size(87, 19);
            this.cbLocalEcho.TabIndex = 1;
            this.cbLocalEcho.Text = "Local Echo";
            this.cbLocalEcho.UseVisualStyleBackColor = true;
            this.cbLocalEcho.CheckedChanged += new System.EventHandler(this.cbLocalEcho_CheckedChanged);
            // 
            // gBSignals
            // 
            this.gBSignals.Controls.Add(this.cbRts);
            this.gBSignals.Controls.Add(this.cbDtr);
            this.gBSignals.Location = new System.Drawing.Point(115, 33);
            this.gBSignals.Name = "gBSignals";
            this.gBSignals.Size = new System.Drawing.Size(100, 80);
            this.gBSignals.TabIndex = 2;
            this.gBSignals.TabStop = false;
            this.gBSignals.Text = "Signals";
            // 
            // cbRts
            // 
            this.cbRts.AutoSize = true;
            this.cbRts.Enabled = false;
            this.cbRts.Location = new System.Drawing.Point(25, 52);
            this.cbRts.Name = "cbRts";
            this.cbRts.Size = new System.Drawing.Size(50, 19);
            this.cbRts.TabIndex = 1;
            this.cbRts.Text = "RTS";
            this.cbRts.UseVisualStyleBackColor = true;
            this.cbRts.CheckedChanged += new System.EventHandler(this.cbRts_CheckedChanged);
            // 
            // cbDtr
            // 
            this.cbDtr.AutoSize = true;
            this.cbDtr.Enabled = false;
            this.cbDtr.Location = new System.Drawing.Point(25, 27);
            this.cbDtr.Name = "cbDtr";
            this.cbDtr.Size = new System.Drawing.Size(51, 19);
            this.cbDtr.TabIndex = 0;
            this.cbDtr.Text = "DTR";
            this.cbDtr.UseVisualStyleBackColor = true;
            this.cbDtr.CheckedChanged += new System.EventHandler(this.cbDtr_CheckedChanged);
            // 
            // lState
            // 
            this.lState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lState.AutoSize = true;
            this.lState.Location = new System.Drawing.Point(5, 443);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(99, 15);
            this.lState.TabIndex = 5;
            this.lState.Text = "Com Port Closed";
            // 
            // openKeysFileDialog
            // 
            this.openKeysFileDialog.Filter = "PushKeys file(*.pkf)|*.pkf";
            // 
            // saveKeysFileDialog
            // 
            this.saveKeysFileDialog.Filter = "PushKeys file(*.pkf)|*.pkf";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.lState);
            this.Controls.Add(this.gBSignals);
            this.Controls.Add(this.gbTerminal);
            this.Controls.Add(this.gbSendMessage);
            this.Controls.Add(this.gbKeys);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(730, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCOT - Simple COm Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbKeys.ResumeLayout(false);
            this.gbSendMessage.ResumeLayout(false);
            this.gbSendMessage.PerformLayout();
            this.gbTerminal.ResumeLayout(false);
            this.gbTerminal.PerformLayout();
            this.pHexLog.ResumeLayout(false);
            this.pHexLog.PerformLayout();
            this.gBSignals.ResumeLayout(false);
            this.gBSignals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miConnection;
        private System.Windows.Forms.ToolStripMenuItem miComPort;
        private System.Windows.Forms.ToolStripMenuItem miOpenPort;
        private System.Windows.Forms.ToolStripMenuItem miClosePort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem miDtr;
        private System.Windows.Forms.ToolStripMenuItem miRts;
        private System.Windows.Forms.ToolStripMenuItem miPushKeys;
        private System.Windows.Forms.ToolStripMenuItem loadPushKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePushKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miSendKey1;
        private System.Windows.Forms.ToolStripMenuItem miSendKey2;
        private System.Windows.Forms.ToolStripMenuItem miSendKey3;
        private System.Windows.Forms.ToolStripMenuItem miSendKey4;
        private System.Windows.Forms.ToolStripMenuItem miSendKey5;
        private System.Windows.Forms.ToolStripMenuItem miSendKey6;
        private System.Windows.Forms.ToolStripMenuItem miSendKey7;
        private System.Windows.Forms.ToolStripMenuItem miSendKey8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miSetPushKeys;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.Button bSetPushKeys;
        private System.Windows.Forms.Button bSendKey8;
        private System.Windows.Forms.Button bSendKey2;
        private System.Windows.Forms.Button bSendKey3;
        private System.Windows.Forms.Button bSendKey4;
        private System.Windows.Forms.Button bSendKey5;
        private System.Windows.Forms.Button bSendKey6;
        private System.Windows.Forms.Button bSendKey7;
        private System.Windows.Forms.Button bSendKey1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button bSendMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ToolStripMenuItem miNewConnection;
        private System.Windows.Forms.ToolStripMenuItem miOpenConnection;
        private System.Windows.Forms.ToolStripMenuItem miCloseConnection;
        private System.Windows.Forms.ToolStripMenuItem miSaveConnection;
        private System.Windows.Forms.ToolStripMenuItem miSaveAsConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Label lHelpMessage;
        private System.Windows.Forms.GroupBox gbKeys;
        private System.Windows.Forms.GroupBox gbSendMessage;
        private System.Windows.Forms.GroupBox gbTerminal;
        private System.Windows.Forms.CheckBox cbLocalEcho;
        private System.Windows.Forms.Button bPrintTerminal;
        private System.Windows.Forms.Button bClearTerminal;
        private System.Windows.Forms.TextBox tbTerminal;
        private System.Windows.Forms.Panel pHexLog;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbNonAscii;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBSignals;
        private System.Windows.Forms.ToolStripMenuItem miPrintTerminal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.CheckBox cbRts;
        private System.Windows.Forms.CheckBox cbDtr;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.OpenFileDialog openKeysFileDialog;
        private System.Windows.Forms.SaveFileDialog saveKeysFileDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}

