using System;
using System.Collections.Generic;
using System.ComponentModel;
using TesteBombaV1Vs2022.Models;
using TesteBombaV1Vs2022.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteBombaV1Vs2022.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}