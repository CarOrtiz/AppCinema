using CinemaDCO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaDCO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResumenCompra : ContentPage
       
    {
        public int precio = 500;
        public int cantidad = 5;
        public int totalPago = 2500;
        public ResumenCompra(Funcion func, int cantid, Cartelera cartelera)
        {
            InitializeComponent();
            datos.BindingContext = cartelera;
            funcion.BindingContext = func;

            Resumen resumen = new Resumen();
            resumen.precio = func.Precio;
            resumen.cantidad = cantid;
            resumen.total = func.Precio * cantid;

            tiquetes.BindingContext = resumen;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Muy Bien!", "La reserva se ha generado correctamente", "Ok");
        }
    
    }
}