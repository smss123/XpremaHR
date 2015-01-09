namespace xprema_HR.XJob
{
    partial class frmAddJob
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
            System.Windows.Forms.Label jobNameLabel;
            System.Windows.Forms.Label jobDescriptionLabel;
            System.Windows.Forms.Label groupIDLabel;
            this.jobDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.btnOky = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.groupIDComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            jobNameLabel = new System.Windows.Forms.Label();
            jobDescriptionLabel = new System.Windows.Forms.Label();
            groupIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupIDComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIDComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIDComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // jobNameLabel
            // 
            jobNameLabel.AutoSize = true;
            jobNameLabel.Location = new System.Drawing.Point(42, 70);
            jobNameLabel.Name = "jobNameLabel";
            jobNameLabel.Size = new System.Drawing.Size(60, 13);
            jobNameLabel.TabIndex = 1;
            jobNameLabel.Text = "Job Name:";
            // 
            // jobDescriptionLabel
            // 
            jobDescriptionLabel.AutoSize = true;
            jobDescriptionLabel.Location = new System.Drawing.Point(10, 96);
            jobDescriptionLabel.Name = "jobDescriptionLabel";
            jobDescriptionLabel.Size = new System.Drawing.Size(90, 13);
            jobDescriptionLabel.TabIndex = 3;
            jobDescriptionLabel.Text = "Job Description:";
            // 
            // jobDescriptionTextBox
            // 
            this.jobDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobDescription", true));
            this.jobDescriptionTextBox.Location = new System.Drawing.Point(106, 93);
            this.jobDescriptionTextBox.Multiline = true;
            this.jobDescriptionTextBox.Name = "jobDescriptionTextBox";
            this.jobDescriptionTextBox.Size = new System.Drawing.Size(180, 104);
            this.jobDescriptionTextBox.TabIndex = 4;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(XpremaDataLayer.Job);
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.Location = new System.Drawing.Point(106, 67);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.jobNameTextBox.TabIndex = 5;
            this.jobNameTextBox.Text = "radTextBox1";
            // 
            // btnOky
            // 
            this.btnOky.Location = new System.Drawing.Point(208, 304);
            this.btnOky.Name = "btnOky";
            this.btnOky.Size = new System.Drawing.Size(110, 24);
            this.btnOky.TabIndex = 6;
            this.btnOky.Text = "Oky";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.groupIDComboBox);
            this.radGroupBox1.Controls.Add(groupIDLabel);
            this.radGroupBox1.Controls.Add(this.jobNameTextBox);
            this.radGroupBox1.Controls.Add(jobDescriptionLabel);
            this.radGroupBox1.Controls.Add(this.jobDescriptionTextBox);
            this.radGroupBox1.Controls.Add(jobNameLabel);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(8, 34);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(309, 264);
            this.radGroupBox1.TabIndex = 7;
            // 
            // groupIDLabel
            // 
            groupIDLabel.AutoSize = true;
            groupIDLabel.Location = new System.Drawing.Point(54, 43);
            groupIDLabel.Name = "groupIDLabel";
            groupIDLabel.Size = new System.Drawing.Size(46, 13);
            groupIDLabel.TabIndex = 5;
            groupIDLabel.Text = "Group :";
            // 
            // groupIDComboBox
            // 
            // 
            // groupIDComboBox.NestedRadGridView
            // 
            this.groupIDComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.groupIDComboBox.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIDComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupIDComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.groupIDComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.groupIDComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.groupIDComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.groupIDComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.groupIDComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.groupIDComboBox.EditorControl.Name = "NestedRadGridView";
            this.groupIDComboBox.EditorControl.ReadOnly = true;
            this.groupIDComboBox.EditorControl.ShowGroupPanel = false;
            this.groupIDComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.groupIDComboBox.EditorControl.TabIndex = 0;
            this.groupIDComboBox.Location = new System.Drawing.Point(106, 41);
            this.groupIDComboBox.Name = "groupIDComboBox";
            this.groupIDComboBox.Size = new System.Drawing.Size(141, 20);
            this.groupIDComboBox.TabIndex = 7;
            this.groupIDComboBox.TabStop = false;
            this.groupIDComboBox.Text = "radMultiColumnComboBox1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(253, 41);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(33, 20);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "...";
            // 
            // frmAddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 348);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnOky);
            this.Name = "frmAddJob";
            this.Text = "frmAddJob";
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupIDComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIDComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIDComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.TextBox jobDescriptionTextBox;
        private Telerik.WinControls.UI.RadTextBox jobNameTextBox;
        private Telerik.WinControls.UI.RadButton btnOky;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox groupIDComboBox;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}