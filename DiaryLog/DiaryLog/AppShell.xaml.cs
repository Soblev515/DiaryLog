using DiaryLog.ViewModels;
using DiaryLog.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DiaryLog
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewTaskPage), typeof(NewTaskPage));
        }
    }
}
