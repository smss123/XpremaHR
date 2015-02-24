namespace xprema_HR.XEpenses
{
    partial class frmAddExpenssesMovment
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label amountLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.AccountsComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.catograycmb = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.txtdescripe = new Telerik.WinControls.UI.RadTextBox();
            this.txtamount = new Telerik.WinControls.UI.RadTextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catograycmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catograycmb.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catograycmb.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescripe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(11, 224);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2013Light";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 66);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(26, 31);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Amount:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(83, 54);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(231, 117);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // AccountsComboBox
            // 
            // 
            // AccountsComboBox.NestedRadGridView
            // 
            this.AccountsComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.AccountsComboBox.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccountsComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.AccountsComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.AccountsComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.AccountsComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.AccountsComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.AccountsComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.AccountsComboBox.EditorControl.Name = "NestedRadGridView";
            this.AccountsComboBox.EditorControl.ReadOnly = true;
            this.AccountsComboBox.EditorControl.ShowGroupPanel = false;
            this.AccountsComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.AccountsComboBox.EditorControl.TabIndex = 0;
            this.AccountsComboBox.Location = new System.Drawing.Point(83, 186);
            this.AccountsComboBox.Name = "AccountsComboBox";
            this.AccountsComboBox.NullText = "Select Category Name";
            this.AccountsComboBox.Size = new System.Drawing.Size(231, 20);
            this.AccountsComboBox.TabIndex = 1;
            this.AccountsComboBox.TabStop = false;
            this.AccountsComboBox.ThemeName = "Office2013Light";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.White;
            this.amountTextBox.Location = new System.Drawing.Point(83, 28);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(162, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(XpremaDataLayer.Account);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.txtdescripe);
            this.groupBox1.Controls.Add(this.catograycmb);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(amountLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // catograycmb
            // 
            this.catograycmb.DataSource = this.accountBindingSource;
            // 
            // catograycmb.NestedRadGridView
            // 
            this.catograycmb.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.catograycmb.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catograycmb.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.catograycmb.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // catograycmb.NestedRadGridView
            // 
            this.catograycmb.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.catograycmb.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.catograycmb.EditorControl.MasterTemplate.AllowColumnChooser = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.FieldName = "AccountName";
            gridViewTextBoxColumn1.HeaderText = "AccountName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "AccountName";
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Description";
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.FieldName = "CategoryID";
            gridViewDecimalColumn2.HeaderText = "CategoryID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "CategoryID";
            gridViewTextBoxColumn3.DataType = typeof(System.Data.Linq.EntitySet<XpremaDataLayer.AccountDaily>);
            gridViewTextBoxColumn3.FieldName = "AccountDailies";
            gridViewTextBoxColumn3.HeaderText = "AccountDailies";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "AccountDailies";
            gridViewTextBoxColumn4.DataType = typeof(System.Data.Linq.EntitySet<XpremaDataLayer.Expenss>);
            gridViewTextBoxColumn4.FieldName = "Expensses";
            gridViewTextBoxColumn4.HeaderText = "Expensses";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Expensses";
            gridViewTextBoxColumn5.DataType = typeof(XpremaDataLayer.AccountCategory);
            gridViewTextBoxColumn5.FieldName = "AccountCategory";
            gridViewTextBoxColumn5.HeaderText = "AccountCategory";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "AccountCategory";
            this.catograycmb.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.catograycmb.EditorControl.MasterTemplate.DataSource = this.accountBindingSource;
            this.catograycmb.EditorControl.MasterTemplate.EnableGrouping = false;
            this.catograycmb.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.catograycmb.EditorControl.Name = "NestedRadGridView";
            this.catograycmb.EditorControl.ReadOnly = true;
            this.catograycmb.EditorControl.ShowGroupPanel = false;
            this.catograycmb.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.catograycmb.EditorControl.TabIndex = 0;
            this.catograycmb.Location = new System.Drawing.Point(83, 186);
            this.catograycmb.Name = "catograycmb";
            this.catograycmb.NullText = "Select Category Name";
            this.catograycmb.Size = new System.Drawing.Size(231, 20);
            this.catograycmb.TabIndex = 4;
            this.catograycmb.TabStop = false;
            this.catograycmb.ThemeName = "Office2013Light";
            // 
            // txtdescripe
            // 
            this.txtdescripe.AutoSize = false;
            this.txtdescripe.Location = new System.Drawing.Point(83, 63);
            this.txtdescripe.Multiline = true;
            this.txtdescripe.Name = "txtdescripe";
            this.txtdescripe.NullText = "Enter Description (optional)";
            this.txtdescripe.Size = new System.Drawing.Size(231, 117);
            this.txtdescripe.TabIndex = 8;
            this.txtdescripe.ThemeName = "Office2013Light";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(83, 28);
            this.txtamount.Name = "txtamount";
            this.txtamount.NullText = "Enter Amount";
            this.txtamount.Size = new System.Drawing.Size(171, 21);
            this.txtamount.TabIndex = 7;
            this.txtamount.ThemeName = "Office2013Light";
            // 
            // frmAddExpenssesMovment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 293);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddExpenssesMovment";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Add New Expensses Movment";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catograycmb.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catograycmb.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catograycmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescripe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox AccountsComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox catograycmb;
        private Telerik.WinControls.UI.RadTextBox txtdescripe;
        private Telerik.WinControls.UI.RadTextBox txtamount;
    }
}
