using IMS_BISP.Sessions;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Dashboard
{
    public static class ucDashboard
    {
        public static Control Load()
        {
            if (UserSession.IsAdmin())
                return new ucDashboardAdmin();
            else
                return new ucDashboardManager();
        }
    }
}
