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
    public partial class frmAddAcount : RadForm
    {
        public frmAddAcount()
        {
            InitializeComponent();
        }

        private void frmAddAcount_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This  error for account name 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountNameTextBox.Text))
            {
                EPAccountName.Icon = Properties.Resources.err;
                EPAccountName.SetError(accountNameTextBox, "Description valid ");

            }
            else
            {
                EPAccountName.Icon = Properties.Resources.acept;
                EPAccountName.SetError(accountNameTextBox, "Ok");
            }
        }

        private void btnOky_Click(object sender, EventArgs e)
        {       
            ///this for error acount name
            if (string.IsNullOrEmpty(accountNameTextBox.Text))
            {
                EPAccountName.Icon = Properties.Resources.err;
                EPAccountName.SetError(accountNameTextBox, "Description valid ");

            }
            else
            {
                EPAccountName.Icon = Properties.Resources.acept;
                EPAccountName.SetError(accountNameTextBox, "Ok");
            }
        }
    }
}
