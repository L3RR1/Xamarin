using System.ComponentModel;
using TesteBombaV1Vs2022.ViewModels;
using Xamarin.Forms;

namespace TesteBombaV1Vs2022.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}