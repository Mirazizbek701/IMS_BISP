using IMS_BISP.DAL.Data;
using IMS_BISP.Sessions;
using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = UserRepository.GetByUsername(username);

            if (user == null || !user.IsActive)
            {
                MessageBox.Show("Invalid username or password.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UserRepository.VerifyPassword(password, user.PasswordHash))
            {
                MessageBox.Show("Invalid username or password.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserSession.UserId = user.UserId;
            UserSession.StoreId = user.StoreId;
            UserSession.StoreName = user.StoreName;
            UserSession.RoleId = user.RoleId;
            UserSession.RoleName = user.RoleName;
            UserSession.Username = user.Username;
            UserSession.FullName = user.FullName;

            AuditLogRepository.Insert(user.UserId, "LOGIN", $"{user.Username} logged in.");

            var main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
