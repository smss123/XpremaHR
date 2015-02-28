using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace xprema_HR.XAccounts
{
    public partial class FrmAccountTree : Telerik.WinControls.UI.RadForm
    {
        public FrmAccountTree()
        {
            InitializeComponent();
        }
        

       /// <summary>
       /// this Error for Account Name 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAccountName.Text))
            {
                EPAccountName.Icon = Properties.Resources.err;
                EPAccountName.SetError(txtAccountName, "Description valid ");

            }
            else
            {
                EPAccountName.Icon = Properties.Resources.acept;
                EPAccountName.SetError(txtAccountName, "Ok");
            }
        }
        /// <summary>
        /// this for description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Leave_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                EPDescription.Icon = Properties.Resources.err;
                EPDescription.SetError (txtDescription,"Description valid ");

            }
            else
            {
                EPDescription.Icon = Properties.Resources.acept;
                EPDescription.SetError(txtDescription, "Ok");
            }
        }

        /// <summary>
        /// This Error for 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Leave_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcridet.Text))
            {
                EPCridet.Icon = Properties.Resources.err;
                EPCridet.SetError(txtcridet, "Description valid ");

            }
            else
            {
                EPCridet.Icon = Properties.Resources.acept;
                EPCridet.SetError(txtcridet, "Ok");
            }
        }




    }
}
