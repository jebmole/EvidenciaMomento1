using Momento1_JEB.Models;
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
	public partial class ProductosPage : ContentPage
	{
		public ProductosPage ()
		{
			InitializeComponent ();
            CargarProductos();
		}

        private void CargarProductos()
        {
            var listado = new List<Producto>
            {
                new Producto{ Nombre = "Producto 1", Descripcion = "Descripcion 1", Cantidad=9, Imagen="luffy.png"},
                new Producto{ Nombre = "Producto 2", Descripcion = "Descripcion 2", Cantidad=5, Imagen="luffy.png"},
                new Producto{ Nombre = "Producto 3", Descripcion = "Descripcion 3", Cantidad=3, Imagen="luffy.png"},
                new Producto{ Nombre = "Producto 4", Descripcion = "Descripcion 4", Cantidad=2, Imagen="luffy.png"},
                new Producto{ Nombre = "Producto 5", Descripcion = "Descripcion 5", Cantidad=1, Imagen="luffy.png"}
            };

            listProductos.ItemsSource = listado;
        }

        private async void ProductoSeleccionado(object sender, SelectedItemChangedEventArgs e)
        {
            var producto = e.SelectedItem as Producto;
            string mensaje = string.Format("Producto : {0} - Cantidad : {1}", producto.Nombre, producto.Cantidad);
            await DisplayAlert("Producto seleccionado", mensaje, "Ok");
        }
    }
}