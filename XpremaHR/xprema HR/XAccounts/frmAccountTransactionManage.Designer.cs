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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountTransactionManage));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.accountDailiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDailiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.accountDailiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailiesBindingNavigator)).BeginInit();
            this.accountDailiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDailiesBindingSource
            // 
            this.accountDailiesBindingSource.DataSource = typeof(System.Data.Linq.EntitySet<XpremaDataLayer.AccountDaily>);
            // 
            // accountDailiesBindingNavigator
            // 
            this.accountDailiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountDailiesBindingNavigator.BindingSource = this.accountDailiesBindingSource;
            this.accountDailiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountDailiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accountDailiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.accountDailiesBindingNavigatorSaveItem});
            this.accountDailiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountDailiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountDailiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountDailiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountDailiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountDailiesBindingNavigator.Name = "accountDailiesBindingNavigator";
            this.accountDailiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountDailiesBindingNavigator.Size = new System.Drawing.Size(781, 25);
            this.accountDailiesBindingNavigator.TabIndex = 0;
            this.accountDailiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // accountDailiesBindingNavigatorSaveItem
            // 
            this.accountDailiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountDailiesBindingNavigatorSaveItem.Enabled = false;
            this.accountDailiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountDailiesBindingNavigatorSaveItem.Image")));
            this.accountDailiesBindingNavigatorSaveItem.Name = "accountDailiesBindingNavigatorSaveItem";
            this.accountDailiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.accountDailiesBindingNavigatorSaveItem.Text = "Save Data";
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
            gridViewDecimalColumn1.Width = 124;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.FieldName = "AccountID";
            gridViewDecimalColumn2.HeaderText = "AccountID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "AccountID";
            gridViewDecimalColumn2.Width = 124;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn3.FieldName = "TotalIn";
            gridViewDecimalColumn3.HeaderText = "Creadit";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "TotalIn";
            gridViewDecimalColumn3.Width = 124;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn4.FieldName = "TotalOut";
            gridViewDecimalColumn4.HeaderText = "Debet";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "TotalOut";
            gridViewDecimalColumn4.Width = 124;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.FieldName = "DateOfProcess";
            gridViewDateTimeColumn1.HeaderText = "date";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "DateOfProcess";
            gridViewDateTimeColumn1.Width = 124;
            gridViewTextBoxColumn1.FieldName = "Description";
            gridViewTextBoxColumn1.HeaderText = "Description";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Description";
            gridViewTextBoxColumn1.Width = 121;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.accountDailiesBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(757, 319);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // frmAccountTransactionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 387);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.accountDailiesBindingNavigator);
            this.Name = "frmAccountTransactionManage";
            this.Text = "frmAccountTransactionManage";
            ((System.ComponentModel.ISupportInitialize)(this.accountDailiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailiesBindingNavigator)).EndInit();
            this.accountDailiesBindingNavigator.ResumeLayout(false);
            this.accountDailiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource accountDailiesBindingSource;
        private System.Windows.Forms.BindingNavigator accountDailiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton accountDailiesBindingNavigatorSaveItem;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}