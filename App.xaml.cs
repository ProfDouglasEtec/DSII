namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Usamos NavigationPage para que funcione PushAsync e PopAsync
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
