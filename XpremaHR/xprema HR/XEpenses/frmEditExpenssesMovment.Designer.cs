namespace xprema_HR.XEpenses
{
    partial class frmEditExpenssesMovment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new Telerik.WinControls.UI.RadButton();
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            this.txtdescripe = new Telerik.WinControls.UI.RadTextBox();
            this.EPAmount = new System.Windows.Forms.ErrorProvider(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            expenssesNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnupdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescripe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 66);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // expenssesNameLabel
            // 
            expenssesNameLabel.AutoSize = true;
            expenssesNameLabel.Location = new System.Drawing.Point(26, 31);
            expenssesNameLabel.Name = "expenssesNameLabel";
            expenssesNameLabel.Size = new System.Drawing.Size(48, 13);
            expenssesNameLabel.TabIndex = 0;
            expenssesNameLabel.Text = "Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtdescripe);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(expenssesNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Data";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(10, 219);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(109, 37);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.ThemeName = "Office2013Light";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(83, 28);
            this.txtname.Name = "txtname";
            this.txtname.NullText = "Enter Name";
            this.txtname.Size = new System.Drawing.Size(213, 21);
            this.txtname.TabIndex = 8;
            this.txtname.ThemeName = "Office2013Light";
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // txtdescripe
            // 
            this.txtdescripe.AutoSize = false;
            this.txtdescripe.Location = new System.Drawing.Point(83, 63);
            this.txtdescripe.Multiline = true;
            this.txtdescripe.Name = "txtdescripe";
            this.txtdescripe.NullText = "Enter Description (optional)";
            this.txtdescripe.Size = new System.Drawing.Size(231, 117);
            this.txtdescripe.TabIndex = 9;
            this.txtdescripe.ThemeName = "Office2013Light";
            // 
            // EPAmount
            // 
            this.EPAmount.ContainerControl = this;
            // 
            // frmEditExpenssesMovment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 293);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditExpenssesMovment";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmEditExpenssesMovment";
            this.ThemeName = "Office2013Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnupdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescripe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnupdate;
        private Telerik.WinControls.UI.RadTextBox txtname;
        private Telerik.WinControls.UI.RadTextBox txtdescripe;
        private System.Windows.Forms.ErrorProvider EPAmount;
    }
}
