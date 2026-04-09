namespace IMS_BISP.Forms
{
    partial class frmAddEditStore
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblFormTitle     = new System.Windows.Forms.Label();
            this.lblStoreName     = new System.Windows.Forms.Label();
            this.tbxStoreName     = new System.Windows.Forms.TextBox();
            this.lblContactPhone  = new System.Windows.Forms.Label();
            this.tbxContactPhone  = new System.Windows.Forms.TextBox();
            this.btnSave          = new System.Windows.Forms.Button();
            this.btnCancel        = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblFormTitle
            //
            this.lblFormTitle.AutoSize  = false;
            this.lblFormTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFormTitle.Location  = new System.Drawing.Point(0, 15);
            this.lblFormTitle.Name      = "lblFormTitle";
            this.lblFormTitle.Size      = new System.Drawing.Size(380, 28);
            this.lblFormTitle.TabIndex  = 0;
            this.lblFormTitle.Text      = "Add Store";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblStoreName
            //
            this.lblStoreName.AutoSize  = true;
            this.lblStoreName.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStoreName.Location  = new System.Drawing.Point(25, 58);
            this.lblStoreName.Name      = "lblStoreName";
            this.lblStoreName.TabIndex  = 1;
            this.lblStoreName.Text      = "Store Name *";
            //
            // tbxStoreName
            //
            this.tbxStoreName.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxStoreName.Location = new System.Drawing.Point(25, 78);
            this.tbxStoreName.Name     = "tbxStoreName";
            this.tbxStoreName.Size     = new System.Drawing.Size(330, 24);
            this.tbxStoreName.TabIndex = 2;
            //
            // lblContactPhone
            //
            this.lblContactPhone.AutoSize  = true;
            this.lblContactPhone.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactPhone.Location  = new System.Drawing.Point(25, 115);
            this.lblContactPhone.Name      = "lblContactPhone";
            this.lblContactPhone.TabIndex  = 3;
            this.lblContactPhone.Text      = "Contact Phone";
            //
            // tbxContactPhone
            //
            this.tbxContactPhone.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxContactPhone.Location = new System.Drawing.Point(25, 135);
            this.tbxContactPhone.Name     = "tbxContactPhone";
            this.tbxContactPhone.Size     = new System.Drawing.Size(330, 24);
            this.tbxContactPhone.TabIndex = 4;
            //
            // btnSave
            //
            this.btnSave.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSave.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize  = 0;
            this.btnSave.Font                       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor                  = System.Drawing.Color.White;
            this.btnSave.Location                   = new System.Drawing.Point(185, 178);
            this.btnSave.Name                       = "btnSave";
            this.btnSave.Size                       = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex                   = 5;
            this.btnSave.Text                       = "Save";
            this.btnSave.UseVisualStyleBackColor    = false;
            this.btnSave.Click                     += new System.EventHandler(this.btnSave_Click);
            //
            // btnCancel
            //
            this.btnCancel.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnCancel.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize  = 0;
            this.btnCancel.Font                       = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor                  = System.Drawing.Color.White;
            this.btnCancel.Location                   = new System.Drawing.Point(275, 178);
            this.btnCancel.Name                       = "btnCancel";
            this.btnCancel.Size                       = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex                   = 6;
            this.btnCancel.Text                       = "Cancel";
            this.btnCancel.UseVisualStyleBackColor    = false;
            this.btnCancel.Click                     += new System.EventHandler(this.btnCancel_Click);
            //
            // frmAddEditStore
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(380, 225);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.tbxStoreName);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.tbxContactPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox      = false;
            this.MinimizeBox      = false;
            this.Name             = "frmAddEditStore";
            this.StartPosition    = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text             = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label   lblFormTitle;
        private System.Windows.Forms.Label   lblStoreName;
        private System.Windows.Forms.TextBox tbxStoreName;
        private System.Windows.Forms.Label   lblContactPhone;
        private System.Windows.Forms.TextBox tbxContactPhone;
        private System.Windows.Forms.Button  btnSave;
        private System.Windows.Forms.Button  btnCancel;
    }
}
