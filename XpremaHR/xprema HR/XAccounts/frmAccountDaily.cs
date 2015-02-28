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
    public partial class frmAccountDaily : RadForm
    {
        public frmAccountDaily()
        {
            InitializeComponent();
        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void frmAccountDaily_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This error for description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            /// this for error description
            if (string.IsNullOrEmpty(radTextBox1.Text))
            {
                EPDescription.Icon = Properties.Resources.err;
                EPDescription.SetError(radTextBox1, "Description valid please check it! ");

            }
            else
            {
                EPDescription.Icon = Properties.Resources.acept;
                EPDescription.SetError(radTextBox1, "Ok");
            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

         
    }
}
