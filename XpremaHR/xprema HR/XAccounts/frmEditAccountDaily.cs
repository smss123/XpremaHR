using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace xprema_HR.XAccounts
{
    public partial class frmEditAccountDaily : RadForm
    {
        public frmEditAccountDaily()
        {
            InitializeComponent();
        }

        private void frmEditAccountDaily_Load(object sender, EventArgs e)
        {

        }

        private void radTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(radTextBox1.Text))
            {
                EPDescription.Icon = Properties.Resources.err;
                EPDescription.SetError(radTextBox1, "Description valid ");

            }
            else
            {
                EPDescription.Icon = Properties.Resources.acept;
                EPDescription.SetError(radTextBox1, "Ok");
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            /// This error for des
            if (string.IsNullOrEmpty(radTextBox1.Text))
            {
                EPDescription.Icon = Properties.Resources.err;
                EPDescription.SetError(radTextBox1, "Description valid ");

            }
            else
            {
                EPDescription.Icon = Properties.Resources.acept;
                EPDescription.SetError(radTextBox1, "Ok");
            }
        }
    }
}
