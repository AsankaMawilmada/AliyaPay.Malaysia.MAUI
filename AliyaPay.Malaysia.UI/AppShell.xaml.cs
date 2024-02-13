using AliyaPay.Malaysia.UI.Pages;

namespace Exchange.Monitor.MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        }
    }
}
