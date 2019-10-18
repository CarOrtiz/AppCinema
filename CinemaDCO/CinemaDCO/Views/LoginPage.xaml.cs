using Newtonsoft.Json;
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
            await Navigation.PushAsync(new CarteleraPage());
        }
    
    }
}