﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavigationPage8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage3 : ContentPage
    {
        public MainPage3()
        {
            InitializeComponent();
        }

        private async void NavegarParaProximaPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage4());
        }
    }
}