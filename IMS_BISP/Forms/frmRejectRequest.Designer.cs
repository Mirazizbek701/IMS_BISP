namespace IMS_BISP.Forms
{
    partial class frmRejectRequest
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblFormTitle  = new System.Windows.Forms.Label();
            this.lblNote       = new System.Windows.Forms.Label();
            this.tbxNote       = new System.Windows.Forms.TextBox();
            this.btnConfirm    = new System.Windows.Forms.Button();
            this.btnCancel     = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblFormTitle
            this.lblFormTitle.AutoSize  = false;
            this.lblFormTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFormTitle.Location  = new System.Drawing.Point(0, 12);
            this.lblFormTitle.Name      = "lblFormTitle";
            this.lblFormTitle.Size      = new System.Drawing.Size(400, 28);
            this.lblFormTitle.TabIndex  = 0;
            this.lblFormTitle.Text      = "Reject Request";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblNote
            this.lblNote.AutoSize = true;
            this.lblNote.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNote.Location = new System.Drawing.Point(20, 52);
            this.lblNote.Name     = "lblNote";
            this.lblNote.TabIndex = 1;
            this.lblNote.Text     = "Rejection Note *";
            // tbxNote
            this.tbxNote.Font       = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxNote.Location   = new System.Drawing.Point(20, 72);
            this.tbxNote.Multiline  = true;
            this.tbxNote.Name       = "tbxNote";
            this.tbxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxNote.Size       = new System.Drawing.Size(360, 80);
            this.tbxNote.TabIndex   = 2;
            // btnConfirm
            this.btnConfirm.BackColor                  = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnConfirm.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.FlatAppearance.BorderSize  = 0;
            this.btnConfirm.Font                       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor                  = System.Drawing.Color.White;
            this.btnConfirm.Location                   = new System.Drawing.Point(205, 170);
            this.btnConfirm.Name                       = "btnConfirm";
            this.btnConfirm.Size                       = new System.Drawing.Size(80, 30);
            this.btnConfirm.TabIndex                   = 3;
            this.btnConfirm.Text                       = "Reject";
            this.btnConfirm.UseVisualStyleBackColor    = false;
            this.btnConfirm.Click                     += new System.EventHandler(this.btnConfirm_Click);
            // btnCancel
            this.btnCancel.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnCancel.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize  = 0;
            this.btnCancel.Font                       = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor                  = System.Drawing.Color.White;
            this.btnCancel.Location                   = new System.Drawing.Point(295, 170);
            this.btnCancel.Name                       = "btnCancel";
            this.btnCancel.Size                       = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex                   = 4;
            this.btnCancel.Text                       = "Cancel";
            this.btnCancel.UseVisualStyleBackColor    = false;
            this.btnCancel.Click                     += new System.EventHandler(this.btnCancel_Click);
            // frmRejectRequest
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(400, 218);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox      = false;
            this.MinimizeBox      = false;
            this.Name             = "frmRejectRequest";
            this.StartPosition    = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text             = "Reject Request";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label    lblFormTitle;
        private System.Windows.Forms.Label    lblNote;
        private System.Windows.Forms.TextBox  tbxNote;
        private System.Windows.Forms.Button   btnConfirm;
        private System.Windows.Forms.Button   btnCancel;
    }
}
