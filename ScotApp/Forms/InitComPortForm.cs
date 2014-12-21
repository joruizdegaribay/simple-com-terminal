using System;
using System.IO.Ports;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScotApp.Forms
{
    public partial class InitComPortForm : Form
    {
        public InitComPortForm()
        {
            InitializeComponent();
            foreach (string portName in SerialPort.GetPortNames())
            {
                string finalName = portName;
                while (!char.IsNumber(finalName[finalName.Length-1]))
                    finalName = finalName.Substring(0, portName.Length - 1);
                this.cbPortName.Items.Add(finalName);
            }
        }

        private void InitComPortForm_Load(object sender, EventArgs e)
        {
            this.cbPortName.SelectedItem = ComPort.Default.PORT_NAME;
            this.cbBaudRate.SelectedItem = ComPort.Default.BAUD_RATE.ToString();
            switch (ComPort.Default.DATA_BITS)
            {
                case 6:
                    this.rb6.Checked = true;
                    break;
                case 7:
                    this.rb7.Checked = true;
                    break;
                case 8:
                    this.rb8.Checked = true;
                    break;
            }
            switch (ComPort.Default.STOP_BITS)
            {
                case StopBits.One:
                    this.rb1.Checked = true;
                    break;
                case StopBits.OnePointFive:
                    this.rb15.Checked = true;
                    break;
                case StopBits.Two:
                    this.rb2.Checked = true;
                    break;
            }
            switch (ComPort.Default.PARITY)
            {
                case Parity.None:
                    this.rbNone.Checked = true;
                    break;
                case Parity.Odd:
                    this.rbOdd.Checked = true;
                    break;
                case Parity.Even:
                    this.rbEven.Checked = true;
                    break;
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            ComPort.Default.PORT_NAME = (string)this.cbPortName.SelectedItem;
            ComPort.Default.BAUD_RATE = Convert.ToInt32(this.cbBaudRate.SelectedItem);
            if (this.rb6.Checked)
                ComPort.Default.DATA_BITS = 6;
            else
                if (this.rb7.Checked)
                    ComPort.Default.DATA_BITS = 7;
                else
                    ComPort.Default.DATA_BITS = 8;
            if (this.rb1.Checked)
                ComPort.Default.STOP_BITS = StopBits.One;
            else
                if (this.rb15.Checked)
                    ComPort.Default.STOP_BITS = StopBits.OnePointFive;
                else
                    ComPort.Default.STOP_BITS = StopBits.Two;
            if (this.rbNone.Checked)
                ComPort.Default.PARITY = Parity.None;
            else
                if (this.rbOdd.Checked)
                    ComPort.Default.PARITY = Parity.Odd;
                else
                    ComPort.Default.PARITY = Parity.Even;
            ComPort.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void InitComPortForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void cbPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbPortName.SelectedIndex != -1)
                this.bOpen.Enabled = true;
            else
                this.bOpen.Enabled = false;
        }
    }
}
