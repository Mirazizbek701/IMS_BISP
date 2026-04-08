using IMS_BISP.DAL.Data;
using IMS_BISP.Forms;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace IMS_BISP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var cs = ConfigurationManager.ConnectionStrings["MalikaTechMarketDB"];
                if (cs == null || string.IsNullOrWhiteSpace(cs.ConnectionString))
                {
                    MessageBox.Show(
                        "Connection string 'MalikaTechMarketDB' is missing from App.config.\nThe application cannot start.",
                        "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DatabaseHelper.ConnectionString = cs.ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load application configuration:\n" + ex.Message,
                    "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (true)
            {
                var login = new frmLogin();
                Application.Run(login);

                if (!login.LoginSuccessful)
                    break;

                var main = new MainForm();
                Application.Run(main);

                if (!main.ShouldLogout)
                    break;
            }
        }
    }
}