using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TesteBombaV1Vs2022.Views;
using Xamarin.Forms;

namespace TesteBombaV1Vs2022.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public Command BombaCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            BombaCommand = new Command(OnBombaClicked);

        }
        
        
        
        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void OnBombaClicked()
        {
            
            try
            {
            await App.Current.MainPage.DisplayAlert("BOOOOOM", "funciona merda","ok" );            

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
