﻿using CinemaDCO.Domain;
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
    public partial class FuncionesPage : ContentPage
    {
        public FuncionesPage(Cartelera cartelera)
        {
            InitializeComponent();
            datos.BindingContext = cartelera;
            funciones.ItemsSource = cartelera.Funciones;
        }

        private async void cartelera_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Funcion)e.SelectedItem;
            Cartelera carte = (Cartelera)datos.BindingContext;

            if(cantidadBoletas.Text != null && cantidadBoletas.Text != " ")
            {
                int cantidad = int.Parse(cantidadBoletas.Text);

                if(cantidad > 0)
                {
                    await Navigation.PushAsync(new ResumenCompraPage(item, cantidad, carte));
                }
                else
                {
                    await DisplayAlert("Alerta", "La cantidad minima es 1", "Ok");
                }
            }
        }
    }
}