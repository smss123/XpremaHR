﻿using System;
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
    public partial class frmAccountManagement : RadForm
    {
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            frmAddAcount frm = new frmAddAcount();
            frm.ShowDialog();
        }
    }
}
