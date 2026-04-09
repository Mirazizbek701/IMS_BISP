namespace IMS_BISP.Forms
{
    partial class frmAddEditUser
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
            this.lblFormTitle    = new System.Windows.Forms.Label();
            this.lblFullName     = new System.Windows.Forms.Label();
            this.tbxFullName     = new System.Windows.Forms.TextBox();
            this.lblUsername     = new System.Windows.Forms.Label();
            this.tbxUsername     = new System.Windows.Forms.TextBox();
            this.lblPassword     = new System.Windows.Forms.Label();
            this.tbxPassword     = new System.Windows.Forms.TextBox();
            this.lblRole         = new System.Windows.Forms.Label();
            this.cmbRole         = new System.Windows.Forms.ComboBox();
            this.lblStore        = new System.Windows.Forms.Label();
            this.cmbStore        = new System.Windows.Forms.ComboBox();
            this.btnSave         = new System.Windows.Forms.Button();
            this.btnCancel       = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblFormTitle
            //
            this.lblFormTitle.AutoSize  = false;
            this.lblFormTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFormTitle.Location  = new System.Drawing.Point(0, 15);
            this.lblFormTitle.Name      = "lblFormTitle";
            this.lblFormTitle.Size      = new System.Drawing.Size(420, 28);
            this.lblFormTitle.TabIndex  = 0;
            this.lblFormTitle.Text      = "Add User";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblFullName
            //
            this.lblFullName.AutoSize  = true;
            this.lblFullName.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.Location  = new System.Drawing.Point(25, 58);
            this.lblFullName.Name      = "lblFullName";
            this.lblFullName.TabIndex  = 1;
            this.lblFullName.Text      = "Full Name *";
            //
            // tbxFullName
            //
            this.tbxFullName.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxFullName.Location = new System.Drawing.Point(25, 78);
            this.tbxFullName.Name     = "tbxFullName";
            this.tbxFullName.Size     = new System.Drawing.Size(370, 24);
            this.tbxFullName.TabIndex = 2;
            //
            // lblUsername
            //
            this.lblUsername.AutoSize  = true;
            this.lblUsername.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.Location  = new System.Drawing.Point(25, 115);
            this.lblUsername.Name      = "lblUsername";
            this.lblUsername.TabIndex  = 3;
            this.lblUsername.Text      = "Username *";
            //
            // tbxUsername
            //
            this.tbxUsername.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxUsername.Location = new System.Drawing.Point(25, 135);
            this.tbxUsername.Name     = "tbxUsername";
            this.tbxUsername.Size     = new System.Drawing.Size(175, 24);
            this.tbxUsername.TabIndex = 4;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize  = true;
            this.lblPassword.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.Location  = new System.Drawing.Point(220, 115);
            this.lblPassword.Name      = "lblPassword";
            this.lblPassword.TabIndex  = 5;
            this.lblPassword.Text      = "Password *";
            //
            // tbxPassword
            //
            this.tbxPassword.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxPassword.Location = new System.Drawing.Point(220, 135);
            this.tbxPassword.Name     = "tbxPassword";
            this.tbxPassword.Size     = new System.Drawing.Size(175, 24);
            this.tbxPassword.TabIndex = 6;
            //
            // lblRole
            //
            this.lblRole.AutoSize  = true;
            this.lblRole.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRole.Location  = new System.Drawing.Point(25, 173);
            this.lblRole.Name      = "lblRole";
            this.lblRole.TabIndex  = 7;
            this.lblRole.Text      = "Role *";
            //
            // cmbRole
            //
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRole.Location      = new System.Drawing.Point(25, 193);
            this.cmbRole.Name          = "cmbRole";
            this.cmbRole.Size          = new System.Drawing.Size(175, 26);
            this.cmbRole.TabIndex      = 8;
            //
            // lblStore
            //
            this.lblStore.AutoSize  = true;
            this.lblStore.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStore.Location  = new System.Drawing.Point(220, 173);
            this.lblStore.Name      = "lblStore";
            this.lblStore.TabIndex  = 9;
            this.lblStore.Text      = "Store *";
            //
            // cmbStore
            //
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbStore.Location      = new System.Drawing.Point(220, 193);
            this.cmbStore.Name          = "cmbStore";
            this.cmbStore.Size          = new System.Drawing.Size(175, 26);
            this.cmbStore.TabIndex      = 10;
            //
            // btnSave
            //
            this.btnSave.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSave.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize  = 0;
            this.btnSave.Font                       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor                  = System.Drawing.Color.White;
            this.btnSave.Location                   = new System.Drawing.Point(225, 243);
            this.btnSave.Name                       = "btnSave";
            this.btnSave.Size                       = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex                   = 11;
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
            this.btnCancel.Location                   = new System.Drawing.Point(315, 243);
            this.btnCancel.Name                       = "btnCancel";
            this.btnCancel.Size                       = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex                   = 12;
            this.btnCancel.Text                       = "Cancel";
            this.btnCancel.UseVisualStyleBackColor    = false;
            this.btnCancel.Click                     += new System.EventHandler(this.btnCancel_Click);
            //
            // frmAddEditUser
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(420, 292);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.tbxFullName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox      = false;
            this.MinimizeBox      = false;
            this.Name             = "frmAddEditUser";
            this.StartPosition    = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text             = "User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label    lblFormTitle;
        private System.Windows.Forms.Label    lblFullName;
        private System.Windows.Forms.TextBox  tbxFullName;
        private System.Windows.Forms.Label    lblUsername;
        private System.Windows.Forms.TextBox  tbxUsername;
        private System.Windows.Forms.Label    lblPassword;
        private System.Windows.Forms.TextBox  tbxPassword;
        private System.Windows.Forms.Label    lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label    lblStore;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Button   btnSave;
        private System.Windows.Forms.Button   btnCancel;
    }
}
