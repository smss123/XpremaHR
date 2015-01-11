namespace xprema_HR.XEmployee
{
    partial class FrmEmployeeManage
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtempname = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.employeeBasicInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtempname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBasicInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txtempname);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Search";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(388, 78);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Search";
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(115, 33);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(209, 20);
            this.txtempname.TabIndex = 11;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radLabel1.Location = new System.Drawing.Point(34, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 18);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "EMP Name:";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGridView1);
            this.radGroupBox2.HeaderText = "Employes List";
            this.radGroupBox2.Location = new System.Drawing.Point(13, 98);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(1132, 477);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Employes List";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(6, 32);
            // 
            // radGridView1
            // 
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "SerialNumber";
            gridViewDecimalColumn1.HeaderText = "SerialNumber";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "SerialNumber";
            gridViewDecimalColumn1.Width = 76;
            gridViewTextBoxColumn1.DataType = typeof(System.Guid);
            gridViewTextBoxColumn1.FieldName = "EmpNumber";
            gridViewTextBoxColumn1.HeaderText = "EmpNumber";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "EmpNumber";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "EmpName";
            gridViewTextBoxColumn2.HeaderText = "EmpName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "EmpName";
            gridViewTextBoxColumn2.Width = 250;
            gridViewTextBoxColumn3.FieldName = "Address";
            gridViewTextBoxColumn3.HeaderText = "Address";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Address";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "MobileNo";
            gridViewTextBoxColumn4.HeaderText = "MobileNo";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "MobileNo";
            gridViewTextBoxColumn4.Width = 60;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "Email";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 60;
            gridViewTextBoxColumn6.FieldName = "BloodGroup";
            gridViewTextBoxColumn6.HeaderText = "BloodGroup";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "BloodGroup";
            gridViewTextBoxColumn6.Width = 69;
            gridViewTextBoxColumn7.FieldName = "Nationalty";
            gridViewTextBoxColumn7.HeaderText = "Nationalty";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Nationalty";
            gridViewTextBoxColumn7.Width = 60;
            gridViewTextBoxColumn8.FieldName = "nationaltyID";
            gridViewTextBoxColumn8.HeaderText = "nationaltyID";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "nationaltyID";
            gridViewTextBoxColumn8.Width = 69;
            gridViewTextBoxColumn9.FieldName = "status";
            gridViewTextBoxColumn9.HeaderText = "status";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "status";
            gridViewTextBoxColumn9.Width = 38;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.FieldName = "JobID";
            gridViewDecimalColumn2.HeaderText = "JobID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "JobID";
            gridViewDecimalColumn2.Width = 36;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.FieldName = "CreateDate";
            gridViewDateTimeColumn1.HeaderText = "CreateDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "CreateDate";
            gridViewDateTimeColumn1.Width = 64;
            gridViewDateTimeColumn2.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn2.FieldName = "HereDate";
            gridViewDateTimeColumn2.HeaderText = "HereDate";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "HereDate";
            gridViewDateTimeColumn2.Width = 55;
            gridViewTextBoxColumn10.DataType = typeof(System.Data.Linq.EntitySet<XpremaDataLayer.User>);
            gridViewTextBoxColumn10.FieldName = "Users";
            gridViewTextBoxColumn10.HeaderText = "Users";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "Users";
            gridViewTextBoxColumn10.Width = 35;
            gridViewTextBoxColumn11.DataType = typeof(XpremaDataLayer.Job);
            gridViewTextBoxColumn11.FieldName = "Job";
            gridViewTextBoxColumn11.HeaderText = "Job";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "Job";
            gridViewTextBoxColumn11.Width = 40;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn2,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.radGridView1.MasterTemplate.DataSource = this.employeeBasicInfoBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1121, 440);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "VisualStudio2012Light";
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // employeeBasicInfoBindingSource
            // 
            this.employeeBasicInfoBindingSource.DataSource = typeof(XpremaDataLayer.EmployeeBasicInfo);
            // 
            // FrmEmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 587);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmEmployeeManage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmEmployeeManage";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtempname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBasicInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtempname;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource employeeBasicInfoBindingSource;
    }
}
