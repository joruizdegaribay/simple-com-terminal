using System;
using System.Windows.Forms;

namespace ScotApp.Forms
{
    public partial class SetPushKeysForm : Form
    {
        #region Private atributes

        private bool[] messageValidated = new bool[] { true, true, true, true, true, true, true, true, true, true };

        #endregion

        public SetPushKeysForm()
        {
            InitializeComponent();
        }

        private void SetPushKeysForm_Load(object sender, EventArgs e)
        {
            this.tbKey1.Text = PushKeys.Default.KEY_1;
            this.tbKey2.Text = PushKeys.Default.KEY_2;
            this.tbKey3.Text = PushKeys.Default.KEY_3;
            this.tbKey4.Text = PushKeys.Default.KEY_4;
            this.tbKey5.Text = PushKeys.Default.KEY_5;
            this.tbKey6.Text = PushKeys.Default.KEY_6;
            this.tbKey7.Text = PushKeys.Default.KEY_7;
            this.tbKey8.Text = PushKeys.Default.KEY_8;
            this.tbKey9.Text = PushKeys.Default.KEY_9;
            this.tbKey10.Text = PushKeys.Default.KEY_10;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                if (!this.messageValidated[i])
                {
                    MessageBox.Show("One or more messages are not correct", "SCOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            PushKeys.Default.KEY_1 = this.tbKey1.Text;
            PushKeys.Default.KEY_2 = this.tbKey2.Text;
            PushKeys.Default.KEY_3 = this.tbKey3.Text;
            PushKeys.Default.KEY_4 = this.tbKey4.Text;
            PushKeys.Default.KEY_5 = this.tbKey5.Text;
            PushKeys.Default.KEY_6 = this.tbKey6.Text;
            PushKeys.Default.KEY_7 = this.tbKey7.Text;
            PushKeys.Default.KEY_8 = this.tbKey8.Text;
            PushKeys.Default.KEY_9 = this.tbKey9.Text;
            PushKeys.Default.KEY_10 = this.tbKey10.Text;
            PushKeys.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SetPushKeysForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void tbKey1_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey1.Text))
            {
                this.messageValidated[0] = true;
                this.pbValidate1.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[0] = false;
                this.pbValidate1.Image = validateIcons.Images[1];
            }
        }

        private void tbKey2_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey2.Text))
            {
                this.messageValidated[1] = true;
                this.pbValidate2.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[1] = false;
                this.pbValidate2.Image = validateIcons.Images[1];
            }
        }

        private void tbKey3_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey3.Text))
            {
                this.messageValidated[2] = true;
                this.pbValidate3.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[2] = false;
                this.pbValidate3.Image = validateIcons.Images[1];
            }
        }

        private void tbKey4_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey4.Text))
            {
                this.messageValidated[3] = true;
                this.pbValidate4.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[3] = false;
                this.pbValidate4.Image = validateIcons.Images[1];
            }
        }

        private void tbKey5_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey5.Text))
            {
                this.messageValidated[4] = true;
                this.pbValidate5.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[4] = false;
                this.pbValidate5.Image = validateIcons.Images[1];
            }
        }

        private void tbKey6_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey6.Text))
            {
                this.messageValidated[5] = true;
                this.pbValidate6.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[5] = false;
                this.pbValidate6.Image = validateIcons.Images[1];
            }
        }

        private void tbKey7_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey7.Text))
            {
                this.messageValidated[6] = true;
                this.pbValidate7.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[6] = false;
                this.pbValidate7.Image = validateIcons.Images[1];
            }
        }

        private void tbKey8_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey8.Text))
            {
                this.messageValidated[7] = true;
                this.pbValidate8.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[7] = false;
                this.pbValidate8.Image = validateIcons.Images[1];
            }
        }

        private void tbKey9_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey9.Text))
            {
                this.messageValidated[8] = true;
                this.pbValidate9.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[8] = false;
                this.pbValidate9.Image = validateIcons.Images[1];
            }
        }

        private void tbKey10_TextChanged(object sender, EventArgs e)
        {
            if (MainForm.ValidateMessage(this.tbKey10.Text))
            {
                this.messageValidated[9] = true;
                this.pbValidate10.Image = validateIcons.Images[0];
            }
            else
            {
                this.messageValidated[9] = false;
                this.pbValidate10.Image = validateIcons.Images[1];
            }
        }
    }
}
