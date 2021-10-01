using CoachApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CoachApp.Views
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