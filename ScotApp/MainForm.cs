using System;
using System.IO.Ports;
using System.Xml;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ScotApp.Forms;

namespace ScotApp
{
    public partial class MainForm : Form
    {
        #region Atributes

        private SerialPort comPort = new SerialPort();
        
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Eventos del formulario

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.updateKeysToolTip();
            //se actualizan las configuraciones del terminal
            this.cbLocalEcho.Checked = General.Default.LOCAL_ECHO;
            switch (General.Default.HEX_LOG)
            {
                case "Off":
                    this.rbOff.Checked = true;
                    break;
                case "NonAscii":
                    this.rbNonAscii.Checked = true;
                    break;
                case "All":
                    this.rbAll.Checked = true;
                    break;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.comPort.IsOpen)
                this.closeComPort();
        }

        #endregion

        #region Eventos del menú principal

        private void miPrintTerminal_Click(object sender, EventArgs e)
        {
            this.printTerminal();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miOpenPort_Click(object sender, EventArgs e)
        {
            if (this.comPort.IsOpen)
                this.closeComPort();
            InitComPortForm initComPortForm = new InitComPortForm();
            do
            {
                if (DialogResult.OK == initComPortForm.ShowDialog())
                {
                    this.comPort.PortName = ComPort.Default.PORT_NAME;
                    this.comPort.BaudRate = ComPort.Default.BAUD_RATE;
                    this.comPort.Parity = ComPort.Default.PARITY;
                    this.comPort.DataBits = ComPort.Default.DATA_BITS;
                    this.comPort.StopBits = ComPort.Default.STOP_BITS;
                    try
                    {
                        this.comPort.Open();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to open port", "SCOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    this.miClosePort.Enabled = true;
                    this.miDtr.Checked = this.cbDtr.Checked = this.comPort.DtrEnable;
                    this.miDtr.Enabled = this.cbDtr.Enabled = true;
                    this.miRts.Checked = this.cbRts.Checked = this.comPort.RtsEnable;
                    this.miRts.Enabled = this.cbRts.Enabled = true;
                    this.miSendKey1.Enabled = this.bSendKey1.Enabled = true;
                    this.miSendKey2.Enabled = this.bSendKey2.Enabled = true;
                    this.miSendKey3.Enabled = this.bSendKey3.Enabled = true;
                    this.miSendKey4.Enabled = this.bSendKey4.Enabled = true;
                    this.miSendKey5.Enabled = this.bSendKey5.Enabled = true;
                    this.miSendKey6.Enabled = this.bSendKey6.Enabled = true;
                    this.miSendKey7.Enabled = this.bSendKey7.Enabled = true;
                    this.miSendKey8.Enabled = this.bSendKey8.Enabled = true;
                    this.miSendKey9.Enabled = this.bSendKey9.Enabled = true;
                    this.miSendKey10.Enabled = this.bSendKey10.Enabled = true;
                    this.bSendMessage.Enabled = true;
                    this.tReception.Enabled = true;
                    this.lState.Text = "Com Port Opened: " + this.comPort.PortName + " - " + this.comPort.BaudRate.ToString();
                    break;
                }
            }
            while (DialogResult.OK == initComPortForm.DialogResult);
        }

        private void miClosePort_Click(object sender, EventArgs e)
        {
            this.closeComPort();
        }

        private void miDtr_Click(object sender, EventArgs e)
        {
            this.toggleDtr();
        }

        private void miRts_Click(object sender, EventArgs e)
        {
            this.toggleRts();
        }

        private void miSendKey1_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_1);
        }

        private void miSendKey2_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_2);
        }

        private void miSendKey3_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_3);
        }

        private void miSendKey4_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_4);
        }

        private void miSendKey5_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_5);
        }

        private void miSendKey6_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_6);
        }

        private void miSendKey7_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_7);
        }

        private void miSendKey8_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_8);
        }

        private void miSetPushKeys_Click(object sender, EventArgs e)
        {
            this.setPushKeys();
        }

        private void loadPushKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.openKeysFileDialog.ShowDialog())
            {
                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(this.openKeysFileDialog.FileName);
                    XmlNodeList keysNodes = doc.GetElementsByTagName("PushKeys");
                    if (keysNodes[0]["PushKey1"] != null)
                        PushKeys.Default.KEY_1 = keysNodes[0]["PushKey1"].InnerText;
                    else
                        PushKeys.Default.KEY_1 = "";
                    if (keysNodes[0]["PushKey2"] != null)
                        PushKeys.Default.KEY_2 = keysNodes[0]["PushKey2"].InnerText;
                    else
                        PushKeys.Default.KEY_2 = "";
                    if (keysNodes[0]["PushKey3"] != null)
                        PushKeys.Default.KEY_3 = keysNodes[0]["PushKey3"].InnerText;
                    else
                        PushKeys.Default.KEY_3 = "";
                    if (keysNodes[0]["PushKey4"] != null)
                        PushKeys.Default.KEY_4 = keysNodes[0]["PushKey4"].InnerText;
                    else
                        PushKeys.Default.KEY_4 = "";
                    if (keysNodes[0]["PushKey5"] != null)
                        PushKeys.Default.KEY_5 = keysNodes[0]["PushKey5"].InnerText;
                    else
                        PushKeys.Default.KEY_5 = "";
                    if (keysNodes[0]["PushKey6"] != null)
                        PushKeys.Default.KEY_6 = keysNodes[0]["PushKey6"].InnerText;
                    else
                        PushKeys.Default.KEY_6 = "";
                    if (keysNodes[0]["PushKey7"] != null)
                        PushKeys.Default.KEY_7 = keysNodes[0]["PushKey7"].InnerText;
                    else
                        PushKeys.Default.KEY_7 = "";
                    if (keysNodes[0]["PushKey8"] != null)
                        PushKeys.Default.KEY_8 = keysNodes[0]["PushKey8"].InnerText;
                    else
                        PushKeys.Default.KEY_8 = "";
                    if (keysNodes[0]["PushKey9"] != null)
                        PushKeys.Default.KEY_9 = keysNodes[0]["PushKey9"].InnerText;
                    else
                        PushKeys.Default.KEY_9 = "";
                    if (keysNodes[0]["PushKey10"] != null)
                        PushKeys.Default.KEY_10 = keysNodes[0]["PushKey10"].InnerText;
                    else
                        PushKeys.Default.KEY_10 = "";
                    PushKeys.Default.Save();
                    this.updateKeysToolTip();
                }
                catch
                {
                    MessageBox.Show("All PushKeys cannot be loaded");
                }
            }
        }

        private void savePushKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.saveKeysFileDialog.ShowDialog())
            {
                XmlWriter writer = XmlWriter.Create(this.saveKeysFileDialog.FileName);
                writer.WriteStartDocument();
                writer.WriteStartElement("PushKeys");
                writer.WriteElementString("PushKey1", PushKeys.Default.KEY_1);
                writer.WriteElementString("PushKey2", PushKeys.Default.KEY_2);
                writer.WriteElementString("PushKey3", PushKeys.Default.KEY_3);
                writer.WriteElementString("PushKey4", PushKeys.Default.KEY_4);
                writer.WriteElementString("PushKey5", PushKeys.Default.KEY_5);
                writer.WriteElementString("PushKey6", PushKeys.Default.KEY_6);
                writer.WriteElementString("PushKey7", PushKeys.Default.KEY_7);
                writer.WriteElementString("PushKey8", PushKeys.Default.KEY_8);
                writer.WriteElementString("PushKey9", PushKeys.Default.KEY_9);
                writer.WriteElementString("PushKey10", PushKeys.Default.KEY_10);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        #endregion

        #region Button events

        private void bSendKey1_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_1);
        }

        private void bSendKey2_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_2);
        }

        private void bSendKey3_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_3);
        }

        private void bSendKey4_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_4);
        }

        private void bSendKey5_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_5);
        }

        private void bSendKey6_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_6);
        }

        private void bSendKey7_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_7);
        }

        private void bSendKey8_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_8);
        }

        private void bSendKey9_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_9);
        }

        private void bSendKey10_Click(object sender, EventArgs e)
        {
            this.sendMessage(PushKeys.Default.KEY_10);
        }

        private void bSetPushKeys_Click(object sender, EventArgs e)
        {
            this.setPushKeys();
        }

        #endregion

        #region Eventos de las señales de control

        private void cbDtr_CheckedChanged(object sender, EventArgs e)
        {
            this.toggleDtr();
        }

        private void cbRts_CheckedChanged(object sender, EventArgs e)
        {
            this.toggleRts();
        }

        #endregion

        #region Eventos para envio de un mensaje

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if ((this.bSendMessage.Enabled) && (e.KeyCode == Keys.Enter))
                this.sendLiteralMessage(this.tbMessage.Text);
        }

        private void bSendMessage_Click(object sender, EventArgs e)
        {
            this.sendLiteralMessage(this.tbMessage.Text);
        }

        #endregion

        #region Recepción de Datos

        private void tReception_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.comPort.BytesToRead != 0)
                    this.printToTerminal(this.comPort.ReadExisting());
            }
            catch
            {
                this.closeComPort();
            }
        }

        #endregion

        #region Eventos de los controles del terminal

        private void cbLocalEcho_CheckedChanged(object sender, EventArgs e)
        {
            General.Default.LOCAL_ECHO = this.cbLocalEcho.Checked;
            General.Default.Save();
        }

        private void rbOff_CheckedChanged(object sender, EventArgs e)
        {
            General.Default.HEX_LOG = "Off";
            General.Default.Save();
        }

        private void rbNonAscii_CheckedChanged(object sender, EventArgs e)
        {
            General.Default.HEX_LOG = "NonAscii";
            General.Default.Save();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            General.Default.HEX_LOG = "All";
            General.Default.Save();
        }

        private void bPrintTerminal_Click(object sender, EventArgs e)
        {
            this.printTerminal();
        }

        private void bClearTerminal_Click(object sender, EventArgs e)
        {
            this.tbTerminal.Text = "";
        }

        #endregion

        #region Eventos de impresión

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font(FontFamily.GenericSansSerif, 9);
            string[] lines = this.tbTerminal.Text.Split(new char[] { '\n' });
            float yPos = e.MarginBounds.Top;
            foreach (string line in lines)
            {
                SizeF size = e.Graphics.MeasureString(line, printFont);
                if (size.Width < e.MarginBounds.Width)
                {
                    e.Graphics.DrawString(line, printFont, Brushes.Black, e.MarginBounds.Left, yPos);
                    yPos += printFont.GetHeight(e.Graphics);
                }
                else
                {
                    int numLines = (int)(size.Width / e.MarginBounds.Width);
                    if ((size.Width % e.MarginBounds.Width) != 0)
                        numLines++;
                    RectangleF stringArea = new RectangleF(new PointF(e.MarginBounds.Left, yPos), new SizeF(e.MarginBounds.Width, printFont.GetHeight(e.Graphics) * numLines));
                    e.Graphics.DrawString(line, printFont, Brushes.Black, stringArea);
                    yPos += printFont.GetHeight(e.Graphics) * numLines;
                }
            }
        }
        
        #endregion

        #region Métodos privados

        private void closeComPort()
        {
            this.tReception.Enabled = false;
                try
                {
                    this.comPort.Close();
                }
                catch { }
            this.miClosePort.Enabled = false;
            this.miDtr.Checked = this.cbDtr.Checked = false;
            this.miDtr.Enabled = this.cbDtr.Enabled = false;
            this.miRts.Checked = this.cbRts.Checked = false;
            this.miRts.Enabled = this.cbRts.Enabled = false;
            this.miSendKey1.Enabled = this.bSendKey1.Enabled = false;
            this.miSendKey2.Enabled = this.bSendKey2.Enabled = false;
            this.miSendKey3.Enabled = this.bSendKey3.Enabled = false;
            this.miSendKey4.Enabled = this.bSendKey4.Enabled = false;
            this.miSendKey5.Enabled = this.bSendKey5.Enabled = false;
            this.miSendKey6.Enabled = this.bSendKey6.Enabled = false;
            this.miSendKey7.Enabled = this.bSendKey7.Enabled = false;
            this.miSendKey8.Enabled = this.bSendKey8.Enabled = false;
            this.miSendKey9.Enabled = this.bSendKey9.Enabled = false;
            this.miSendKey10.Enabled = this.bSendKey10.Enabled = false;
            this.bSendMessage.Enabled = false;
            this.lState.Text = "Com Port Closed";
        }

        private void printTerminal()
        {
            if (DialogResult.OK == this.printDialog.ShowDialog())
            {
                this.printDocument.PrinterSettings = this.printDialog.PrinterSettings;
                this.printDocument.Print();
            }
        }

        private void updateKeysToolTip()
        {
            this.toolTip.SetToolTip(this.bSendKey1, PushKeys.Default.KEY_1);
            this.toolTip.SetToolTip(this.bSendKey2, PushKeys.Default.KEY_2);
            this.toolTip.SetToolTip(this.bSendKey3, PushKeys.Default.KEY_3);
            this.toolTip.SetToolTip(this.bSendKey4, PushKeys.Default.KEY_4);
            this.toolTip.SetToolTip(this.bSendKey5, PushKeys.Default.KEY_5);
            this.toolTip.SetToolTip(this.bSendKey6, PushKeys.Default.KEY_6);
            this.toolTip.SetToolTip(this.bSendKey7, PushKeys.Default.KEY_7);
            this.toolTip.SetToolTip(this.bSendKey8, PushKeys.Default.KEY_8);
            this.toolTip.SetToolTip(this.bSendKey9, PushKeys.Default.KEY_9);
            this.toolTip.SetToolTip(this.bSendKey10, PushKeys.Default.KEY_10);
        }

        private void setPushKeys()
        {
            SetPushKeysForm setPushKeysForm = new SetPushKeysForm();
            if (DialogResult.OK == setPushKeysForm.ShowDialog())
                this.updateKeysToolTip();
        }

        private void sendLiteralMessage(string message)
        {
            if (!ValidateMessage(message))
                MessageBox.Show("Message format is not correct", "SCOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.sendMessage(message))
                this.tbMessage.Text = "";
        }

        private void sendCharacter(char character)
        {
            string temp = character.ToString();
            this.comPort.Write(temp);
                if (this.cbLocalEcho.Checked)
                    this.printToTerminal(temp);
        }

        private bool sendMessage(string message)
        {
            byte[] dataToSend = new byte[message.Length];
            int j = 0;
            for (int i = 0; i < message.Length; i++, j++)
                if (message[i].Equals('\\'))
                    if (message[i + 1].Equals('\\'))
                    {
                        dataToSend[j] = (byte)'\\';
                        i += 1;
                    }
                    else
                    {
                        string hexString = message.Substring(i + 1, 2).ToUpper();
                        int hexValue = (char.IsLetter(hexString[0])) ? (hexString[0] - 55) * 16 : (hexString[0] - 48) * 16;
                        hexValue += (char.IsLetter(hexString[1])) ? hexString[1] - 55 : hexString[1] - 48;
                        dataToSend[j] = (byte)hexValue;
                        i += 2;
                    }
                else
                    dataToSend[j] = (byte)message[i];
            try
            {
                this.comPort.Write(dataToSend, 0, j);
                if (this.cbLocalEcho.Checked)
                    this.printToTerminal(message);
                return true;
            }
            catch
            {
                this.closeComPort();
                MessageBox.Show("Message could not be sent through Serial Port.\r\nSerial Port has had an error and it must be closed.", "SCOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void printToTerminal(string dataToPrint)
        {
            string temp = "";
            for (int i = 0; i < dataToPrint.Length; i++)
            {
                if (this.rbOff.Checked)
                    temp += (char)dataToPrint[i];
                else if ((this.rbNonAscii.Checked) && !char.IsControl((char)dataToPrint[i]))
                    temp += (char)dataToPrint[i];
                else
                    temp += "<" + this.byteToHex((byte)dataToPrint[i]) + ">";
            }
            this.tbTerminal.AppendText(temp);
        }

        private string byteToHex(byte value)
        {
            string hexValue = "";
            int digit1 = value / 16;
            hexValue += (digit1 > 9) ? ((char)(55 + digit1)).ToString() : digit1.ToString();
            int digit2 = value % 16;
            hexValue += (digit2 > 9) ? ((char)(55 + digit2)).ToString() : digit2.ToString();
            return hexValue;
        }

        private void toggleDtr()
        {
            this.cbDtr.CheckedChanged -= this.cbDtr_CheckedChanged;
            try
            {
                if (this.comPort.DtrEnable)
                {
                    this.comPort.DtrEnable = false;
                    this.miDtr.Checked = false;
                    this.cbDtr.Checked = false;

                }
                else
                {
                    this.comPort.DtrEnable = true;
                    this.miDtr.Checked = true;
                    this.cbDtr.Checked = true;
                }
            }
            catch
            {
                this.closeComPort();
                MessageBox.Show("Dtr pin could not be modified.\r\nSerial Port has had an error and it must be closed.", "SCOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cbDtr.CheckedChanged += this.cbDtr_CheckedChanged;
        }

        private void toggleRts()
        {
            this.cbRts.CheckedChanged -= this.cbRts_CheckedChanged;
            try
            {
                if (this.comPort.RtsEnable)
                {
                    this.comPort.RtsEnable = false;
                    this.miRts.Checked = false;
                    this.cbRts.Checked = false;
                }
                else
                {
                    this.comPort.RtsEnable = true;
                    this.miRts.Checked = true;
                    this.cbRts.Checked = true;
                }
            }
            catch
            {
                this.closeComPort();
                MessageBox.Show("Rts pin could not be modified.\r\nSerial Port has had an error and it must be closed.", "SCOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cbRts.CheckedChanged += this.cbRts_CheckedChanged;
        }
        
        #endregion

        #region Métodos Estáticos

        public static bool ValidateMessage(string message)
        {
            try
            {
                for (int i = 0; i < message.Length; i++)
                    if (message[i].Equals('\\'))
                        if (message[i + 1].Equals('\\'))
                            i += 1;
                        else if (validateHexDigit(message[i + 1]) && validateHexDigit(message[i + 2]))
                            i += 2;
                        else
                            return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool validateHexDigit(char digit)
        {
            if (((digit >= (byte)'A') && (digit <= (byte)'F')) || ((digit >= (byte)'a') && (digit <= (byte)'f')) || char.IsDigit(digit))
                return true;
            else return false;
        }

        #endregion

        private void tbTerminal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbTerminal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.sendCharacter((char)0x0D);
            else if (e.KeyCode == Keys.Escape)
                this.sendCharacter((char)0x1B);
            else if (e.Control && (e.KeyCode == Keys.Z))
                this.sendCharacter((char)0x1A);
            else if (!e.Alt && !e.Control)
                this.sendCharacter((char)e.KeyValue);
        }
    }
}
