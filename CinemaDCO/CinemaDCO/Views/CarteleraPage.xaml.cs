﻿using CinemaDCO.Services;
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
    public partial class CarteleraPage : ContentPage
    {
        public CarteleraPage()
        {
            InitializeComponent();

            lsvCartelera.ItemsSource = PeliculasServices.GetPeliculas();

        }
    }
}