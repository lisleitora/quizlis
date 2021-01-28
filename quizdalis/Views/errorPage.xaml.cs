using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace quizdalis.Views
{
    public partial class errorPage : ContentPage
    {
        public errorPage()
        {
            InitializeComponent();
        }

        void OnSuccess(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new startPage();
        }
    }
}
