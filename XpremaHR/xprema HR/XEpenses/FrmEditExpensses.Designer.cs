namespace xprema_HR.XEpenses
{
    partial class FrmEditExpensses
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label expenssesNameLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdescripe = new Telerik.WinControls.UI.RadTextBox();
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            this.btnOky = new Telerik.WinControls.UI.RadButton();
            descriptionLabel = new System.Windows.Forms.Label();
            expenssesNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescripe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOky);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtdescripe);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(expenssesNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Data";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(32, 66);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // expenssesNameLabel
            // 
            expenssesNameLabel.AutoSize = true;
            expenssesNameLabel.Location = new System.Drawing.Point(7, 26);
            expenssesNameLabel.Name = "expenssesNameLabel";
            expenssesNameLabel.Size = new System.Drawing.Size(92, 13);
            expenssesNameLabel.TabIndex = 0;
            expenssesNameLabel.Text = "Expensses Name:";
            // 
            // txtdescripe
            // 
            this.txtdescripe.AutoSize = false;
            this.txtdescripe.Location = new System.Drawing.Point(102, 63);
            this.txtdescripe.Multiline = true;
            this.txtdescripe.Name = "txtdescripe";
            this.txtdescripe.NullText = "Enter Description (optional)";
            this.txtdescripe.Size = new System.Drawing.Size(231, 117);
            this.txtdescripe.TabIndex = 9;
            this.txtdescripe.ThemeName = "Office2013Light";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(102, 23);
            this.txtname.Name = "txtname";
            this.txtname.NullText = "Enter Name";
            this.txtname.Size = new System.Drawing.Size(213, 21);
            this.txtname.TabIndex = 8;
            this.txtname.ThemeName = "Office2013Light";
            // 
            // btnOky
            // 
            this.btnOky.Location = new System.Drawing.Point(10, 186);
            this.btnOky.Name = "btnOky";
            this.btnOky.Size = new System.Drawing.Size(110, 24);
            this.btnOky.TabIndex = 10;
            this.btnOky.Text = "Update";
            this.btnOky.ThemeName = "Office2013Light";
            // 
            // FrmEditExpensses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditExpensses";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Edit Expensses";
            this.ThemeName = "Office2013Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescripe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadTextBox txtdescripe;
        private Telerik.WinControls.UI.RadTextBox txtname;
        private Telerik.WinControls.UI.RadButton btnOky;
    }
}
