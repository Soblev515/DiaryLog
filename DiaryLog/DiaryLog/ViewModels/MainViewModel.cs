using System;
using System.Globalization;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DiaryLog.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public CultureInfo Culture => new CultureInfo("ru-RU");
        public MainViewModel()
        {
            Title = "Main";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}