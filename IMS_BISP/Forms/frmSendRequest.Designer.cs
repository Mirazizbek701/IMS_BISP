namespace IMS_BISP.Forms
{
    partial class frmSendRequest
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblProductLbl = new System.Windows.Forms.Label();
            this.lblProductVal = new System.Windows.Forms.Label();
            this.lblSupplierLbl = new System.Windows.Forms.Label();
            this.lblSupplierVal = new System.Windows.Forms.Label();
            this.lblPriceLbl = new System.Windows.Forms.Label();
            this.lblPriceVal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblProposedPrice = new System.Windows.Forms.Label();
            this.nudProposedPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProposedPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFormTitle.Location = new System.Drawing.Point(0, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(480, 28);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Request Product";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlInfo.Controls.Add(this.lblProductLbl);
            this.pnlInfo.Controls.Add(this.lblProductVal);
            this.pnlInfo.Controls.Add(this.lblSupplierLbl);
            this.pnlInfo.Controls.Add(this.lblSupplierVal);
            this.pnlInfo.Controls.Add(this.lblPriceLbl);
            this.pnlInfo.Controls.Add(this.lblPriceVal);
            this.pnlInfo.Location = new System.Drawing.Point(20, 52);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(440, 90);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblProductLbl
            // 
            this.lblProductLbl.AutoSize = true;
            this.lblProductLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProductLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblProductLbl.Location = new System.Drawing.Point(10, 10);
            this.lblProductLbl.Name = "lblProductLbl";
            this.lblProductLbl.Size = new System.Drawing.Size(68, 20);
            this.lblProductLbl.TabIndex = 0;
            this.lblProductLbl.Text = "Product:";
            // 
            // lblProductVal
            // 
            this.lblProductVal.AutoSize = true;
            this.lblProductVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProductVal.Location = new System.Drawing.Point(90, 10);
            this.lblProductVal.Name = "lblProductVal";
            this.lblProductVal.Size = new System.Drawing.Size(24, 20);
            this.lblProductVal.TabIndex = 1;
            this.lblProductVal.Text = "—";
            // 
            // lblSupplierLbl
            // 
            this.lblSupplierLbl.AutoSize = true;
            this.lblSupplierLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSupplierLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSupplierLbl.Location = new System.Drawing.Point(10, 36);
            this.lblSupplierLbl.Name = "lblSupplierLbl";
            this.lblSupplierLbl.Size = new System.Drawing.Size(71, 20);
            this.lblSupplierLbl.TabIndex = 2;
            this.lblSupplierLbl.Text = "Supplier:";
            // 
            // lblSupplierVal
            // 
            this.lblSupplierVal.AutoSize = true;
            this.lblSupplierVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSupplierVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSupplierVal.Location = new System.Drawing.Point(90, 36);
            this.lblSupplierVal.Name = "lblSupplierVal";
            this.lblSupplierVal.Size = new System.Drawing.Size(24, 20);
            this.lblSupplierVal.TabIndex = 3;
            this.lblSupplierVal.Text = "—";
            // 
            // lblPriceLbl
            // 
            this.lblPriceLbl.AutoSize = true;
            this.lblPriceLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPriceLbl.Location = new System.Drawing.Point(10, 62);
            this.lblPriceLbl.Name = "lblPriceLbl";
            this.lblPriceLbl.Size = new System.Drawing.Size(93, 20);
            this.lblPriceLbl.TabIndex = 4;
            this.lblPriceLbl.Text = "Listed Price:";
            // 
            // lblPriceVal
            // 
            this.lblPriceVal.AutoSize = true;
            this.lblPriceVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPriceVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPriceVal.Location = new System.Drawing.Point(103, 62);
            this.lblPriceVal.Name = "lblPriceVal";
            this.lblPriceVal.Size = new System.Drawing.Size(24, 20);
            this.lblPriceVal.TabIndex = 5;
            this.lblPriceVal.Text = "—";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuantity.Location = new System.Drawing.Point(14, 158);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(149, 20);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity Requested *";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudQuantity.Location = new System.Drawing.Point(20, 178);
            this.nudQuantity.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 29);
            this.nudQuantity.TabIndex = 3;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblProposedPrice
            // 
            this.lblProposedPrice.AutoSize = true;
            this.lblProposedPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProposedPrice.Location = new System.Drawing.Point(189, 158);
            this.lblProposedPrice.Name = "lblProposedPrice";
            this.lblProposedPrice.Size = new System.Drawing.Size(118, 20);
            this.lblProposedPrice.TabIndex = 4;
            this.lblProposedPrice.Text = "Proposed Price *";
            // 
            // nudProposedPrice
            // 
            this.nudProposedPrice.DecimalPlaces = 2;
            this.nudProposedPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudProposedPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudProposedPrice.Location = new System.Drawing.Point(189, 178);
            this.nudProposedPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudProposedPrice.Name = "nudProposedPrice";
            this.nudProposedPrice.Size = new System.Drawing.Size(140, 29);
            this.nudProposedPrice.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(270, 228);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 30);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(360, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 278);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblProposedPrice);
            this.Controls.Add(this.nudProposedPrice);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request Product";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProposedPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label          lblFormTitle;
        private System.Windows.Forms.Panel          pnlInfo;
        private System.Windows.Forms.Label          lblProductLbl;
        private System.Windows.Forms.Label          lblProductVal;
        private System.Windows.Forms.Label          lblSupplierLbl;
        private System.Windows.Forms.Label          lblSupplierVal;
        private System.Windows.Forms.Label          lblPriceLbl;
        private System.Windows.Forms.Label          lblPriceVal;
        private System.Windows.Forms.Label          lblQuantity;
        private System.Windows.Forms.NumericUpDown  nudQuantity;
        private System.Windows.Forms.Label          lblProposedPrice;
        private System.Windows.Forms.NumericUpDown  nudProposedPrice;
        private System.Windows.Forms.Button         btnSend;
        private System.Windows.Forms.Button         btnCancel;
    }
}
