using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using quizdalis.Views;

namespace quizdalis
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new startPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
