﻿using Modulo2_Cities.Models;
using Modulo2_Cities.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Modulo2_Cities.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}
