namespace IMS_BISP.Forms
{
    partial class frmAddEditProduct
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
            this.lblFormTitle      = new System.Windows.Forms.Label();
            this.lblProductName    = new System.Windows.Forms.Label();
            this.tbxProductName    = new System.Windows.Forms.TextBox();
            this.lblSKU            = new System.Windows.Forms.Label();
            this.tbxSKU            = new System.Windows.Forms.TextBox();
            this.lblCategory       = new System.Windows.Forms.Label();
            this.cmbCategory       = new System.Windows.Forms.ComboBox();
            this.lblQuantity       = new System.Windows.Forms.Label();
            this.nudQuantity       = new System.Windows.Forms.NumericUpDown();
            this.lblUnitPrice      = new System.Windows.Forms.Label();
            this.nudUnitPrice      = new System.Windows.Forms.NumericUpDown();
            this.lblMinThreshold   = new System.Windows.Forms.Label();
            this.nudMinThreshold   = new System.Windows.Forms.NumericUpDown();
            this.lblVisibility     = new System.Windows.Forms.Label();
            this.rbPublic          = new System.Windows.Forms.RadioButton();
            this.rbPrivate         = new System.Windows.Forms.RadioButton();
            this.lblDescription    = new System.Windows.Forms.Label();
            this.tbxDescription    = new System.Windows.Forms.TextBox();
            this.btnSave           = new System.Windows.Forms.Button();
            this.btnCancel         = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinThreshold)).BeginInit();
            this.SuspendLayout();
            // lblFormTitle
            this.lblFormTitle.AutoSize  = false;
            this.lblFormTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFormTitle.Location  = new System.Drawing.Point(0, 12);
            this.lblFormTitle.Name      = "lblFormTitle";
            this.lblFormTitle.Size      = new System.Drawing.Size(460, 28);
            this.lblFormTitle.TabIndex  = 0;
            this.lblFormTitle.Text      = "Add Product";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblProductName
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProductName.Location = new System.Drawing.Point(20, 52);
            this.lblProductName.Name     = "lblProductName";
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text     = "Product Name *";
            // tbxProductName
            this.tbxProductName.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxProductName.Location = new System.Drawing.Point(20, 72);
            this.tbxProductName.Name     = "tbxProductName";
            this.tbxProductName.Size     = new System.Drawing.Size(420, 24);
            this.tbxProductName.TabIndex = 2;
            // lblSKU
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSKU.Location = new System.Drawing.Point(20, 108);
            this.lblSKU.Name     = "lblSKU";
            this.lblSKU.TabIndex = 3;
            this.lblSKU.Text     = "SKU *";
            // tbxSKU
            this.tbxSKU.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxSKU.Location = new System.Drawing.Point(20, 128);
            this.tbxSKU.Name     = "tbxSKU";
            this.tbxSKU.Size     = new System.Drawing.Size(195, 24);
            this.tbxSKU.TabIndex = 4;
            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory.Location = new System.Drawing.Point(240, 108);
            this.lblCategory.Name     = "lblCategory";
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text     = "Category *";
            // cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCategory.Location      = new System.Drawing.Point(240, 128);
            this.cmbCategory.Name          = "cmbCategory";
            this.cmbCategory.Size          = new System.Drawing.Size(200, 26);
            this.cmbCategory.TabIndex      = 6;
            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuantity.Location = new System.Drawing.Point(20, 165);
            this.lblQuantity.Name     = "lblQuantity";
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text     = "Quantity";
            // nudQuantity
            this.nudQuantity.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudQuantity.Location = new System.Drawing.Point(20, 185);
            this.nudQuantity.Maximum  = new decimal(new int[] { 999999, 0, 0, 0 });
            this.nudQuantity.Minimum  = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudQuantity.Name     = "nudQuantity";
            this.nudQuantity.Size     = new System.Drawing.Size(100, 26);
            this.nudQuantity.TabIndex = 8;
            // lblUnitPrice
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUnitPrice.Location = new System.Drawing.Point(140, 165);
            this.lblUnitPrice.Name     = "lblUnitPrice";
            this.lblUnitPrice.TabIndex = 9;
            this.lblUnitPrice.Text     = "Unit Price";
            // nudUnitPrice
            this.nudUnitPrice.DecimalPlaces = 2;
            this.nudUnitPrice.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudUnitPrice.Increment     = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudUnitPrice.Location      = new System.Drawing.Point(140, 185);
            this.nudUnitPrice.Maximum       = new decimal(new int[] { 99999999, 0, 0, 0 });
            this.nudUnitPrice.Minimum       = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudUnitPrice.Name          = "nudUnitPrice";
            this.nudUnitPrice.Size          = new System.Drawing.Size(120, 26);
            this.nudUnitPrice.TabIndex      = 10;
            // lblMinThreshold
            this.lblMinThreshold.AutoSize = true;
            this.lblMinThreshold.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMinThreshold.Location = new System.Drawing.Point(280, 165);
            this.lblMinThreshold.Name     = "lblMinThreshold";
            this.lblMinThreshold.TabIndex = 11;
            this.lblMinThreshold.Text     = "Min Threshold";
            // nudMinThreshold
            this.nudMinThreshold.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudMinThreshold.Location = new System.Drawing.Point(280, 185);
            this.nudMinThreshold.Maximum  = new decimal(new int[] { 99999, 0, 0, 0 });
            this.nudMinThreshold.Minimum  = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudMinThreshold.Name     = "nudMinThreshold";
            this.nudMinThreshold.Size     = new System.Drawing.Size(90, 26);
            this.nudMinThreshold.TabIndex = 12;
            this.nudMinThreshold.Value    = new decimal(new int[] { 5, 0, 0, 0 });
            // lblVisibility
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVisibility.Location = new System.Drawing.Point(20, 224);
            this.lblVisibility.Name     = "lblVisibility";
            this.lblVisibility.TabIndex = 13;
            this.lblVisibility.Text     = "Visibility";
            // rbPublic
            this.rbPublic.Checked   = true;
            this.rbPublic.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbPublic.Location  = new System.Drawing.Point(20, 244);
            this.rbPublic.Name      = "rbPublic";
            this.rbPublic.Size      = new System.Drawing.Size(90, 22);
            this.rbPublic.TabIndex  = 14;
            this.rbPublic.Text      = "PUBLIC";
            // rbPrivate
            this.rbPrivate.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbPrivate.Location = new System.Drawing.Point(120, 244);
            this.rbPrivate.Name     = "rbPrivate";
            this.rbPrivate.Size     = new System.Drawing.Size(90, 22);
            this.rbPrivate.TabIndex = 15;
            this.rbPrivate.Text     = "PRIVATE";
            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.Location = new System.Drawing.Point(20, 278);
            this.lblDescription.Name     = "lblDescription";
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text     = "Description";
            // tbxDescription
            this.tbxDescription.Font       = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxDescription.Location   = new System.Drawing.Point(20, 298);
            this.tbxDescription.Multiline  = true;
            this.tbxDescription.Name       = "tbxDescription";
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescription.Size       = new System.Drawing.Size(420, 75);
            this.tbxDescription.TabIndex   = 17;
            // btnSave
            this.btnSave.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSave.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize  = 0;
            this.btnSave.Font                       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor                  = System.Drawing.Color.White;
            this.btnSave.Location                   = new System.Drawing.Point(265, 392);
            this.btnSave.Name                       = "btnSave";
            this.btnSave.Size                       = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex                   = 18;
            this.btnSave.Text                       = "Save";
            this.btnSave.UseVisualStyleBackColor    = false;
            this.btnSave.Click                     += new System.EventHandler(this.btnSave_Click);
            // btnCancel
            this.btnCancel.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnCancel.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize  = 0;
            this.btnCancel.Font                       = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor                  = System.Drawing.Color.White;
            this.btnCancel.Location                   = new System.Drawing.Point(355, 392);
            this.btnCancel.Name                       = "btnCancel";
            this.btnCancel.Size                       = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex                   = 19;
            this.btnCancel.Text                       = "Cancel";
            this.btnCancel.UseVisualStyleBackColor    = false;
            this.btnCancel.Click                     += new System.EventHandler(this.btnCancel_Click);
            // frmAddEditProduct
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(460, 438);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.tbxSKU);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(this.lblMinThreshold);
            this.Controls.Add(this.nudMinThreshold);
            this.Controls.Add(this.lblVisibility);
            this.Controls.Add(this.rbPublic);
            this.Controls.Add(this.rbPrivate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox      = false;
            this.MinimizeBox      = false;
            this.Name             = "frmAddEditProduct";
            this.StartPosition    = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text             = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label          lblFormTitle;
        private System.Windows.Forms.Label          lblProductName;
        private System.Windows.Forms.TextBox        tbxProductName;
        private System.Windows.Forms.Label          lblSKU;
        private System.Windows.Forms.TextBox        tbxSKU;
        private System.Windows.Forms.Label          lblCategory;
        private System.Windows.Forms.ComboBox       cmbCategory;
        private System.Windows.Forms.Label          lblQuantity;
        private System.Windows.Forms.NumericUpDown  nudQuantity;
        private System.Windows.Forms.Label          lblUnitPrice;
        private System.Windows.Forms.NumericUpDown  nudUnitPrice;
        private System.Windows.Forms.Label          lblMinThreshold;
        private System.Windows.Forms.NumericUpDown  nudMinThreshold;
        private System.Windows.Forms.Label          lblVisibility;
        private System.Windows.Forms.RadioButton    rbPublic;
        private System.Windows.Forms.RadioButton    rbPrivate;
        private System.Windows.Forms.Label          lblDescription;
        private System.Windows.Forms.TextBox        tbxDescription;
        private System.Windows.Forms.Button         btnSave;
        private System.Windows.Forms.Button         btnCancel;
    }
}
