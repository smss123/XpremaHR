namespace xprema_HR.XAccounts
{
    partial class frmGneralLadger
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
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.AccountbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.txtdate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.AccountbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountbindingSource
            // 
            this.AccountbindingSource.DataSource = typeof(XpremaDataLayer.Account);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.radRadioButton2);
            this.radGroupBox1.Controls.Add(this.radRadioButton1);
            this.radGroupBox1.Controls.Add(this.txtdate);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radTextBox1);
            this.radGroupBox1.Controls.Add(this.numericUpDown1);
            this.radGroupBox1.HeaderText = "Entries";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(469, 334);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Entries";
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(252, 103);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(56, 19);
            this.radRadioButton2.TabIndex = 28;
            this.radRadioButton2.Text = "Credit";
            this.radRadioButton2.ThemeName = "Office2013Light";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Location = new System.Drawing.Point(83, 103);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(53, 19);
            this.radRadioButton1.TabIndex = 27;
            this.radRadioButton1.Text = "Debit";
            this.radRadioButton1.ThemeName = "Office2013Light";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(83, 25);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(222, 21);
            this.txtdate.TabIndex = 26;
            this.txtdate.TabStop = false;
            this.txtdate.Text = "Thursday, February 26, 2015";
            this.txtdate.ThemeName = "Office2013Light";
            this.txtdate.Value = new System.DateTime(2015, 2, 26, 21, 11, 25, 447);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(11, 139);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(69, 19);
            this.radLabel4.TabIndex = 22;
            this.radLabel4.Text = "Description";
            this.radLabel4.ThemeName = "Office2013Light";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(29, 78);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(51, 19);
            this.radLabel3.TabIndex = 23;
            this.radLabel3.Text = "Amount";
            this.radLabel3.ThemeName = "Office2013Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(29, 52);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(51, 19);
            this.radLabel2.TabIndex = 24;
            this.radLabel2.Text = "Account";
            this.radLabel2.ThemeName = "Office2013Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(48, 26);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(32, 19);
            this.radLabel1.TabIndex = 25;
            this.radLabel1.Text = "Date";
            this.radLabel1.ThemeName = "Office2013Light";
            // 
            // radTextBox1
            // 
            this.radTextBox1.AutoSize = false;
            this.radTextBox1.Location = new System.Drawing.Point(83, 137);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "Description Here";
            this.radTextBox1.Size = new System.Drawing.Size(222, 132);
            this.radTextBox1.TabIndex = 21;
            this.radTextBox1.ThemeName = "Office2013Light";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 77);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(222, 20);
            this.numericUpDown1.TabIndex = 20;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(83, 292);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 29;
            this.radButton1.Text = "Okay";
            this.radButton1.ThemeName = "Office2013Light";
            // 
            // frmGneralLadger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 339);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "frmGneralLadger";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Gneral Ladger";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.AccountbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.BindingSource AccountbindingSource;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadDateTimePicker txtdate;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
