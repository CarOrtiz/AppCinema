using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaDCO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage: ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
           
        }
        private async void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextUsuario.Text))
            {
                await DisplayAlert("Validación", "El nombre de usuario es requerido", "OK");
                TextUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TextPassword.Text))
            {
                await DisplayAlert("Validación", "La contraseña es requerida", "OK");
                TextPassword.Focus();
                return;
            }

            await Navigation.PushAsync(new CarteleraPage());
        }
    }
}