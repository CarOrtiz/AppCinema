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
    public partial class ResumenCompraPage : ContentPage

    {
        public int precio = 500;
        public int cantidad = 5;
        public int total = 2500;
        public ResumenCompraPage(Funcion func, int cantid, Cartelera cartelera)
        {
            InitializeComponent();
            datos.BindingContext = cartelera;
            funcion.BindingContext = func;

            Tiquete tiquete = new Tiquete();
            tiquete.Precio = func.Precio;
            tiquete.Cantidad = cantid;
            tiquete.TotalPago = func.Precio * cantid;

            tiquetes.BindingContext = tiquete;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Muy Bien!", "Su reserva ha sido exitosa", "Ok");
        }
   
    }
}