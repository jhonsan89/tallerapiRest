using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerApis.xamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApis.xamarin.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PublicacionPage : ContentPage
	{
		public PublicacionPage ()
		{
			InitializeComponent ();
            CargarPublications();
		}

        private async Task CargarPublications()
        {
            {
                HttpClient cliente = new HttpClient();

                cliente.BaseAddress = new Uri("http://192.168.1.51");
                var request = await cliente.GetAsync("http://192.168.1.51/PublicacionApis/Api/Publicacion");
                if (request.IsSuccessStatusCode)
                {
                    var responseJson = await request.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                    listpublicaciones.ItemsSource = response;

                }
            }
        }

    }
}