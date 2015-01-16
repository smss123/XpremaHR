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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn29 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn30 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn31 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn6 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn32 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtempname = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.employeeBasicInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtempname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBasicInfoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txtempname);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Search";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 48);
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
            this.radGroupBox2.Location = new System.Drawing.Point(13, 131);
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
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.FieldName = "SerialNumber";
            gridViewDecimalColumn5.HeaderText = "SerialNumber";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "SerialNumber";
            gridViewDecimalColumn5.Width = 76;
            gridViewTextBoxColumn23.DataType = typeof(System.Guid);
            gridViewTextBoxColumn23.FieldName = "EmpNumber";
            gridViewTextBoxColumn23.HeaderText = "EmpNumber";
            gridViewTextBoxColumn23.IsAutoGenerated = true;
            gridViewTextBoxColumn23.Name = "EmpNumber";
            gridViewTextBoxColumn23.Width = 100;
            gridViewTextBoxColumn24.FieldName = "EmpName";
            gridViewTextBoxColumn24.HeaderText = "EmpName";
            gridViewTextBoxColumn24.IsAutoGenerated = true;
            gridViewTextBoxColumn24.Name = "EmpName";
            gridViewTextBoxColumn24.Width = 250;
            gridViewTextBoxColumn25.FieldName = "Address";
            gridViewTextBoxColumn25.HeaderText = "Address";
            gridViewTextBoxColumn25.IsAutoGenerated = true;
            gridViewTextBoxColumn25.Name = "Address";
            gridViewTextBoxColumn25.Width = 100;
            gridViewTextBoxColumn26.FieldName = "MobileNo";
            gridViewTextBoxColumn26.HeaderText = "MobileNo";
            gridViewTextBoxColumn26.IsAutoGenerated = true;
            gridViewTextBoxColumn26.Name = "MobileNo";
            gridViewTextBoxColumn26.Width = 60;
            gridViewTextBoxColumn27.FieldName = "Email";
            gridViewTextBoxColumn27.HeaderText = "Email";
            gridViewTextBoxColumn27.IsAutoGenerated = true;
            gridViewTextBoxColumn27.Name = "Email";
            gridViewTextBoxColumn27.Width = 60;
            gridViewTextBoxColumn28.FieldName = "BloodGroup";
            gridViewTextBoxColumn28.HeaderText = "BloodGroup";
            gridViewTextBoxColumn28.IsAutoGenerated = true;
            gridViewTextBoxColumn28.Name = "BloodGroup";
            gridViewTextBoxColumn28.Width = 69;
            gridViewTextBoxColumn29.FieldName = "Nationalty";
            gridViewTextBoxColumn29.HeaderText = "Nationalty";
            gridViewTextBoxColumn29.IsAutoGenerated = true;
            gridViewTextBoxColumn29.Name = "Nationalty";
            gridViewTextBoxColumn29.Width = 60;
            gridViewTextBoxColumn30.FieldName = "nationaltyID";
            gridViewTextBoxColumn30.HeaderText = "nationaltyID";
            gridViewTextBoxColumn30.IsAutoGenerated = true;
            gridViewTextBoxColumn30.Name = "nationaltyID";
            gridViewTextBoxColumn30.Width = 69;
            gridViewTextBoxColumn31.FieldName = "status";
            gridViewTextBoxColumn31.HeaderText = "status";
            gridViewTextBoxColumn31.IsAutoGenerated = true;
            gridViewTextBoxColumn31.Name = "status";
            gridViewTextBoxColumn31.Width = 38;
            gridViewDecimalColumn6.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn6.FieldName = "JobID";
            gridViewDecimalColumn6.HeaderText = "JobID";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "JobID";
            gridViewDecimalColumn6.Width = 36;
            gridViewDateTimeColumn5.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn5.FieldName = "CreateDate";
            gridViewDateTimeColumn5.HeaderText = "CreateDate";
            gridViewDateTimeColumn5.IsAutoGenerated = true;
            gridViewDateTimeColumn5.Name = "CreateDate";
            gridViewDateTimeColumn5.Width = 64;
            gridViewDateTimeColumn6.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn6.FieldName = "HereDate";
            gridViewDateTimeColumn6.HeaderText = "HereDate";
            gridViewDateTimeColumn6.IsAutoGenerated = true;
            gridViewDateTimeColumn6.Name = "HereDate";
            gridViewDateTimeColumn6.Width = 55;
            gridViewTextBoxColumn32.FieldName = "Users";
            gridViewTextBoxColumn32.HeaderText = "Users";
            gridViewTextBoxColumn32.IsAutoGenerated = true;
            gridViewTextBoxColumn32.Name = "Users";
            gridViewTextBoxColumn32.Width = 35;
            //gridViewTextBoxColumn33.DataType = typeof(XpremaDataLayer.Job);
            gridViewTextBoxColumn33.FieldName = "Job";
            gridViewTextBoxColumn33.HeaderText = "Job";
            gridViewTextBoxColumn33.IsAutoGenerated = true;
            gridViewTextBoxColumn33.Name = "Job";
            gridViewTextBoxColumn33.Width = 40;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn5,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28,
            gridViewTextBoxColumn29,
            gridViewTextBoxColumn30,
            gridViewTextBoxColumn31,
            gridViewDecimalColumn6,
            gridViewDateTimeColumn5,
            gridViewDateTimeColumn6,
            gridViewTextBoxColumn32,
            gridViewTextBoxColumn33});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1121, 440);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "VisualStudio2012Light";
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // employeeBasicInfoBindingSource
            // 
            //this.employeeBasicInfoBindingSource.DataSource = typeof(XpremaDataLayer.EmployeeBasicInfo);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addbtn,
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1157, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Addbtn
            // 
            this.Addbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Addbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(60, 22);
            this.Addbtn.Text = "Add New";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(100, 22);
            this.RefreshBtn.Text = "Update Emp Info";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmEmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 617);
            this.Controls.Add(this.toolStrip1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtempname;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource employeeBasicInfoBindingSource;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
