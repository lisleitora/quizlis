using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace quizdalis.Views
{
    public partial class q2Page : ContentPage
    {
        public q2Page()
        {
            InitializeComponent();
        }
        void OnFail(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new errorPage();
        }

        void OnSuccess(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new q3Page();
        }
    }
}
