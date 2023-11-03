using lab08.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lab08.Views
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