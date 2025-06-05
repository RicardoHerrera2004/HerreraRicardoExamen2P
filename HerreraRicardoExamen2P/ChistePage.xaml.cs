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
        try
        { 
        var client = new HttpClient();
        var respuesta = await client.GetFromJsonAsync<Chiste>("https://official-joke-api.appspot.com/random_joke");

        if (respuesta != null)
            ChisteL.Text = $" Chiste: {respuesta.setup}\n\n Respuesta: {respuesta.punchline}"; ;
        }
        catch 
        { 
            await DisplayAlert("Error", "No se pudo obtener el chiste. Inténtalo de nuevo más tarde.", "OK"); 
            return; 
        }
    }

    private void ContarChistes_Clicked(object sender, EventArgs e)
    {
		ObtenerChiste();
    }                                                                                                                                                                                                                                                           

    public class Chiste
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}