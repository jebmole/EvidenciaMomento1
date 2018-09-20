using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Momento1_JEB.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelefonoPage : ContentPage
	{
		public TelefonoPage ()
		{
			InitializeComponent ();
		}

        private void Dial(object sender, EventArgs e)
        {
            var button = sender as Button;
            labelNumero.Text += button.Text;
        }

        private async void Llamar(object sender, EventArgs e)
        {
            string mensaje = "Llamando....." + labelNumero.Text;
            await DisplayAlert("Generar Llamada", mensaje, "OK");
        }

        private void Limpiar(object sender, EventArgs e)
        {
            labelNumero.Text = string.Empty;
        }

        private async void Continuar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductosPage());
        }
    }
}