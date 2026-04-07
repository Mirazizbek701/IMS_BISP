using IMS_BISP.Sessions;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Dashboard
{
    public static class ucDashboard
    {
        public static UserControl Load()
        {
            if (UserSession.IsAdmin())
                return (UserControl)(object)new ucDashboardAdmin();
            else
                return (UserControl)(object)new ucDashboardManager();
        }
    }
}
