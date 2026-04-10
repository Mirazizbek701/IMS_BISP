using IMS_BISP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmLowStock : Form
    {
        private List<Product> _products;

        public frmLowStock(List<Product> products)
        {
            InitializeComponent();
            _products = products;
        }

        private void frmLowStock_Load(object sender, EventArgs e)
        {
            dgvLowStock.DataSource = null;
            dgvLowStock.DataSource = _products;
        }

        private void dgvLowStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_products == null) return;
            for (int i = 0; i < dgvLowStock.Rows.Count && i < _products.Count; i++)
            {
                var p = _products[i];
                if (p.Quantity == 0)
                    dgvLowStock.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 102, 102);
                else if (p.Quantity <= p.MinThreshold)
                    dgvLowStock.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 178, 102);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
