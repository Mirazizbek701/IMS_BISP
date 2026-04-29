using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Requests
{
    public partial class ucSentRequests : UserControl
    {
        private List<ProductRequest> _requests;

        public ucSentRequests()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvSentRequests.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvSentRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvSentRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSentRequests.EnableHeadersVisualStyles = false;
            dgvSentRequests.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvSentRequests.RowTemplate.Height = 28;
        }

        private void ucSentRequests_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!UserSession.StoreId.HasValue) return;
            try
            {
                _requests = RequestRepository.GetByRequester(UserSession.StoreId.Value);
                dgvSentRequests.DataSource = null;
                dgvSentRequests.DataSource = _requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load sent requests: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSentRequests_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_requests == null) return;
            for (int i = 0; i < dgvSentRequests.Rows.Count && i < _requests.Count; i++)
            {
                switch (_requests[i].Status)
                {
                    case "PENDING":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                        break;
                    case "ACCEPTED":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                        break;
                    case "REJECTED":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                        break;
                    case "DELIVERED":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(178, 223, 138);
                        break;
                    case "NOT_DELIVERED":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 171, 145);
                        break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
