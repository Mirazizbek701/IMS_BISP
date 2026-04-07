namespace IMS_BISP.Forms
{
    partial class frmResetPassword
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
            this.lblTitle        = new System.Windows.Forms.Label();
            this.lblNewPassword  = new System.Windows.Forms.Label();
            this.tbxNewPassword  = new System.Windows.Forms.TextBox();
            this.btnSave         = new System.Windows.Forms.Button();
            this.btnCancel       = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize  = false;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(0, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Size      = new System.Drawing.Size(340, 28);
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Reset Password";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblNewPassword
            //
            this.lblNewPassword.AutoSize  = true;
            this.lblNewPassword.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNewPassword.Location  = new System.Drawing.Point(25, 58);
            this.lblNewPassword.Name      = "lblNewPassword";
            this.lblNewPassword.TabIndex  = 1;
            this.lblNewPassword.Text      = "New Password *";
            //
            // tbxNewPassword
            //
            this.tbxNewPassword.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxNewPassword.Location = new System.Drawing.Point(25, 78);
            this.tbxNewPassword.Name     = "tbxNewPassword";
            this.tbxNewPassword.Size     = new System.Drawing.Size(290, 24);
            this.tbxNewPassword.TabIndex = 2;
            //
            // btnSave
            //
            this.btnSave.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSave.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize  = 0;
            this.btnSave.Font                       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor                  = System.Drawing.Color.White;
            this.btnSave.Location                   = new System.Drawing.Point(140, 118);
            this.btnSave.Name                       = "btnSave";
            this.btnSave.Size                       = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex                   = 3;
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
            this.btnCancel.Location                   = new System.Drawing.Point(230, 118);
            this.btnCancel.Name                       = "btnCancel";
            this.btnCancel.Size                       = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex                   = 4;
            this.btnCancel.Text                       = "Cancel";
            this.btnCancel.UseVisualStyleBackColor    = false;
            this.btnCancel.Click                     += new System.EventHandler(this.btnCancel_Click);
            //
            // frmResetPassword
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(340, 165);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox      = false;
            this.MinimizeBox      = false;
            this.Name             = "frmResetPassword";
            this.StartPosition    = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text             = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label   lblTitle;
        private System.Windows.Forms.Label   lblNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Button  btnSave;
        private System.Windows.Forms.Button  btnCancel;
    }
}
