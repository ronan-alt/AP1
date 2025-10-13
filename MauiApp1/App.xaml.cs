using AP1.Vues;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Register();

            MainPage = new AppShell();
        }
    }
}
