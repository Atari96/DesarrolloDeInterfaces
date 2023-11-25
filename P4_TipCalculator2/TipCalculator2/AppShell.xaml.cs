namespace TipCalculator2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CustomTipPage), typeof(CustomTipPage));

            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }
}
