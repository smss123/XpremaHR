﻿using System.Data.Linq;

namespace xprema_HR.XAccounts
{
    partial class frmAccountTransactionManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.accountDailiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDailiesBindingSource
            // 
            this.accountDailiesBindingSource.DataSource = typeof(System.Data.Linq.EntitySet<XpremaDataLayer.AccountDaily>);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 28);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 108;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.FieldName = "AccountID";
            gridViewDecimalColumn2.HeaderText = "AccountID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "AccountID";
            gridViewDecimalColumn2.Width = 108;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn3.FieldName = "TotalIn";
            gridViewDecimalColumn3.HeaderText = "Creadit";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "TotalIn";
            gridViewDecimalColumn3.Width = 108;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn4.FieldName = "TotalOut";
            gridViewDecimalColumn4.HeaderText = "Debet";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "TotalOut";
            gridViewDecimalColumn4.Width = 108;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.FieldName = "DateOfProcess";
            gridViewDateTimeColumn1.HeaderText = "date";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "DateOfProcess";
            gridViewDateTimeColumn1.Width = 108;
            gridViewTextBoxColumn1.FieldName = "Description";
            gridViewTextBoxColumn1.HeaderText = "Description";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Description";
            gridViewTextBoxColumn1.Width = 106;
            gridViewCommandColumn1.DefaultText = "Edit";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Name = "btnEdit";
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 45;
            gridViewCommandColumn2.DefaultText = "Delete";
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Name = "btnDelete";
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 48;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.radGridView1.MasterTemplate.DataSource = this.accountDailiesBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(757, 319);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Office2013Light";
            // 
            // frmAccountTransactionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 387);
            this.Controls.Add(this.radGridView1);
            this.Name = "frmAccountTransactionManage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Transection";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.frmAccountTransactionManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDailiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource accountDailiesBindingSource;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}