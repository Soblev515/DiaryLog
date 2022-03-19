using DiaryLog.Models;
using DiaryLog.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiaryLog.Views
{
    public partial class NewTaskPage : ContentPage
    {
        public TaskItem Item { get; set; }

        public NewTaskPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}