namespace xprema_HR.XEpenses
{
    partial class FrmAddExpensses
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
            System.Windows.Forms.Label expenssesNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddExpensses));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.txtdescription = new Telerik.WinControls.UI.RadTextBox();
            this.txtexpname = new Telerik.WinControls.UI.RadTextBox();
            this.expenssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EPAddExpensses = new System.Windows.Forms.ErrorProvider(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            expenssesNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtexpname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPAddExpensses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(32, 66);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(69, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // expenssesNameLabel
            // 
            expenssesNameLabel.AutoSize = true;
            expenssesNameLabel.Location = new System.Drawing.Point(7, 26);
            expenssesNameLabel.Name = "expenssesNameLabel";
            expenssesNameLabel.Size = new System.Drawing.Size(94, 13);
            expenssesNameLabel.TabIndex = 3;
            expenssesNameLabel.Text = "Expensses Name:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnadd);
            this.radGroupBox1.Controls.Add(this.txtdescription);
            this.radGroupBox1.Controls.Add(this.txtexpname);
            this.radGroupBox1.Controls.Add(descriptionLabel);
            this.radGroupBox1.Controls.Add(expenssesNameLabel);
            this.radGroupBox1.HeaderText = "Expensses";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(370, 224);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Expensses";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(20, 169);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 37);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Add";
            this.btnadd.ThemeName = "Office2013Light";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.AutoSize = false;
            this.txtdescription.Location = new System.Drawing.Point(102, 63);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.NullText = "Enter Description (optional)";
            this.txtdescription.Size = new System.Drawing.Size(213, 82);
            this.txtdescription.TabIndex = 8;
            this.txtdescription.ThemeName = "Office2013Light";
            // 
            // txtexpname
            // 
            this.txtexpname.Location = new System.Drawing.Point(102, 24);
            this.txtexpname.Name = "txtexpname";
            this.txtexpname.NullText = "Add Expensses ";
            this.txtexpname.Size = new System.Drawing.Size(213, 20);
            this.txtexpname.TabIndex = 5;
            this.txtexpname.Leave += new System.EventHandler(this.txtexpname_Leave);
            // 
            // expenssBindingSource
            // 
            this.expenssBindingSource.DataSource = typeof(XpremaDataLayer.Expenss);
            // 
            // EPAddExpensses
            // 
            this.EPAddExpensses.ContainerControl = this;
            this.EPAddExpensses.Icon = ((System.Drawing.Icon)(resources.GetObject("EPAddExpensses.Icon")));
            // 
            // FrmAddExpensses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 250);
            this.Controls.Add(this.radGroupBox1);
            this.MaximumSize = new System.Drawing.Size(402, 281);
            this.Name = "FrmAddExpensses";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(402, 281);
            this.Text = "Add New Expensses";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtexpname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPAddExpensses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtexpname;
        private Telerik.WinControls.UI.RadTextBox txtdescription;
        private Telerik.WinControls.UI.RadButton btnadd;
        private System.Windows.Forms.BindingSource expenssBindingSource;
        private System.Windows.Forms.ErrorProvider EPAddExpensses;

    }
}
