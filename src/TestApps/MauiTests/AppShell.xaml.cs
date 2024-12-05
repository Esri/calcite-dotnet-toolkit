namespace MauiTests
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Application.Current!.UserAppTheme = AppTheme.Light;
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            if (Application.Current!.UserAppTheme == AppTheme.Light)
                Application.Current!.UserAppTheme = AppTheme.Dark;
            else
                Application.Current!.UserAppTheme = AppTheme.Light;
        }

        private void GitHubButton_Clicked(object sender, EventArgs e)
        {
            // TODO
        }
    }
}