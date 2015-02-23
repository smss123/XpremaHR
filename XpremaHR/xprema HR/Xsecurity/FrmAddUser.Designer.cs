namespace xprema_HR.Xsecurity
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
          
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtusername = new Telerik.WinControls.UI.RadTextBox();
            this.txtpasswd = new Telerik.WinControls.UI.RadTextBox();
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpasswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.radMultiColumnComboBox1);
            this.radGroupBox1.Controls.Add(this.txtpasswd);
            this.radGroupBox1.Controls.Add(this.txtusername);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Add User";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(317, 209);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Add User";
            this.radGroupBox1.ThemeName = "ControlDefault";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radLabel1.Location = new System.Drawing.Point(19, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 18);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "User Name:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radLabel2.Location = new System.Drawing.Point(19, 77);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(56, 18);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Password:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radLabel3.Location = new System.Drawing.Point(19, 114);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(40, 18);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Group:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(92, 39);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(209, 20);
            this.txtusername.TabIndex = 8;
            // 
            // txtpasswd
            // 
            this.txtpasswd.Location = new System.Drawing.Point(92, 77);
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.Size = new System.Drawing.Size(209, 20);
            this.txtpasswd.TabIndex = 9;
            // 
            // radMultiColumnComboBox1
            // 
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox1.Location = new System.Drawing.Point(92, 111);
            this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            this.radMultiColumnComboBox1.Size = new System.Drawing.Size(209, 20);
            this.radMultiColumnComboBox1.TabIndex = 10;
            this.radMultiColumnComboBox1.TabStop = false;
            this.radMultiColumnComboBox1.Text = "radMultiColumnComboBox1";
            this.radMultiColumnComboBox1.ThemeName = "ControlDefault";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(19, 164);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 11;
            this.radButton1.Text = "Add";
            this.radButton1.ThemeName = "VisualStudio2012Light";
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 234);
            this.Controls.Add(this.radGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddUser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmAddUser";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpasswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtpasswd;
        private Telerik.WinControls.UI.RadTextBox txtusername;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
    }
}
