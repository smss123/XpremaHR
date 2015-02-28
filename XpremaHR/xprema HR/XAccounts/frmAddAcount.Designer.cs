namespace xprema_HR.XAccounts
{
    partial class frmAddAcount
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
            System.Windows.Forms.Label accountNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label categoryIDLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.descriptionTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.categoryIDTextBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.accountCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOky = new Telerik.WinControls.UI.RadButton();
            this.EPAccountName = new System.Windows.Forms.ErrorProvider(this.components);
            accountNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDTextBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDTextBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPAccountName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Location = new System.Drawing.Point(33, 15);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new System.Drawing.Size(80, 13);
            accountNameLabel.TabIndex = 1;
            accountNameLabel.Text = "Account Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(51, 41);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(59, 105);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(59, 13);
            categoryIDLabel.TabIndex = 4;
            categoryIDLabel.Text = "Category :";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(XpremaDataLayer.Account);
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Location = new System.Drawing.Point(120, 12);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.NullText = "Enter Account Name";
            this.accountNameTextBox.Size = new System.Drawing.Size(171, 21);
            this.accountNameTextBox.TabIndex = 6;
            this.accountNameTextBox.ThemeName = "Office2013Light";
            this.accountNameTextBox.Leave += new System.EventHandler(this.accountNameTextBox_Leave);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AutoSize = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(120, 38);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.NullText = "Enter Description (optional)";
            this.descriptionTextBox.Size = new System.Drawing.Size(171, 53);
            this.descriptionTextBox.TabIndex = 7;
            this.descriptionTextBox.ThemeName = "Office2013Light";
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataSource = this.accountCategoryBindingSource;
            this.categoryIDTextBox.DisplayMember = "AccountCategoryName";
            // 
            // categoryIDTextBox.NestedRadGridView
            // 
            this.categoryIDTextBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.categoryIDTextBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoryIDTextBox.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.categoryIDTextBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryIDTextBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.categoryIDTextBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.categoryIDTextBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.categoryIDTextBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.categoryIDTextBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.categoryIDTextBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.categoryIDTextBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ID";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "AccountCategoryName";
            gridViewTextBoxColumn3.HeaderText = "AccountCategoryName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "AccountCategoryName";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Description";
            gridViewTextBoxColumn4.HeaderText = "Description";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Description";
            this.categoryIDTextBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.categoryIDTextBox.EditorControl.MasterTemplate.DataSource = this.accountCategoryBindingSource;
            this.categoryIDTextBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.categoryIDTextBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.categoryIDTextBox.EditorControl.Name = "NestedRadGridView";
            this.categoryIDTextBox.EditorControl.ReadOnly = true;
            this.categoryIDTextBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryIDTextBox.EditorControl.ShowGroupPanel = false;
            this.categoryIDTextBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.categoryIDTextBox.EditorControl.TabIndex = 0;
            this.categoryIDTextBox.Location = new System.Drawing.Point(120, 102);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.NullText = "Category Name";
            this.categoryIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.categoryIDTextBox.TabIndex = 8;
            this.categoryIDTextBox.TabStop = false;
            this.categoryIDTextBox.ThemeName = "Office2013Light";
            this.categoryIDTextBox.ValueMember = "ID";
            // 
            // accountCategoryBindingSource
            // 
            this.accountCategoryBindingSource.DataSource = typeof(XpremaDataLayer.AccountCategory);
            // 
            // btnOky
            // 
            this.btnOky.Location = new System.Drawing.Point(226, 128);
            this.btnOky.Name = "btnOky";
            this.btnOky.Size = new System.Drawing.Size(110, 24);
            this.btnOky.TabIndex = 9;
            this.btnOky.Text = "Oky";
            this.btnOky.ThemeName = "Office2013Light";
            this.btnOky.Click += new System.EventHandler(this.btnOky_Click);
            // 
            // EPAccountName
            // 
            this.EPAccountName.ContainerControl = this;
            // 
            // frmAddAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 160);
            this.Controls.Add(this.btnOky);
            this.Controls.Add(this.categoryIDTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(accountNameLabel);
            this.Name = "frmAddAcount";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.frmAddAcount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDTextBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDTextBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPAccountName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource accountBindingSource;
        private Telerik.WinControls.UI.RadTextBox accountNameTextBox;
        private Telerik.WinControls.UI.RadTextBox descriptionTextBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox categoryIDTextBox;
        private System.Windows.Forms.BindingSource accountCategoryBindingSource;
        private Telerik.WinControls.UI.RadButton btnOky;
        private System.Windows.Forms.ErrorProvider EPAccountName;
    }
}