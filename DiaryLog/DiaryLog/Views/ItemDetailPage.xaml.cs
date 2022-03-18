using DiaryLog.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DiaryLog.Views
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