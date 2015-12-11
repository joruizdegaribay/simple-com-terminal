using System;
using System.Windows.Forms;

namespace ScotApp.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
