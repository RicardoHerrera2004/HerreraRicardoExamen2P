using System.Net.Http.Json;

namespace HerreraRicardoExamen2P;

public partial class ChistePage : ContentPage
{
	public ChistePage()
	{
		InitializeComponent();
        ObtenerChiste();
    }
    private async void ObtenerChiste()
    {
      return;
    }

    private void ContarChistes_Clicked(object sender, EventArgs e)
    {
		ObtenerChiste();
    }                                                                                                                                                                                                                                                           

    public class chiste
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}