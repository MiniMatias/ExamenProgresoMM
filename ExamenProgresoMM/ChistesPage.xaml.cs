using System.Text.Json;

namespace ExamenProgresoMM
{
    public partial class ChistesPage : ContentPage
    {
        HttpClient client = new HttpClient();

        public ChistesPage()
        {
            InitializeComponent();
            CargarChiste();
        }

        private async void CargarChiste()
        {
            try
            {
                var respuesta = await client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
                var json = JsonDocument.Parse(respuesta);
                var setup = json.RootElement.GetProperty("setup").GetString();
                var punchline = json.RootElement.GetProperty("punchline").GetString();
                ChisteLabel.Text = setup + "\n\n" + punchline;
            }
            catch (Exception ex)
            {
                ChisteLabel.Text = "Error al cargar el chiste.";
            }
        }

        private void OnOtroChisteClicked(object sender, EventArgs e)
        {
            CargarChiste();
        }
    }
}