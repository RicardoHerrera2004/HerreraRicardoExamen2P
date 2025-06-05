namespace HerreraRicardoExamen2P
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigationChistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChistePage());
        }

        private void NavigationInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InformacionPage());
        }
    }

}
