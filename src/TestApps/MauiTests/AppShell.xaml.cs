namespace MauiTests
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Application.Current!.UserAppTheme = AppTheme.Light;
            InitializeComponent();
        }

        private void GitHubButton_Clicked(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
