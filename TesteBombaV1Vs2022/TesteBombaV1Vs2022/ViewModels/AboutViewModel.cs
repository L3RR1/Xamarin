using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
namespace TesteBombaV1Vs2022.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            Veiculos = new ObservableCollection<string>
            {
                "Mustang",
                "Camaro",
                "Jetta"
            };
        }



        public ICommand OpenWebCommand { get; }
    }
}