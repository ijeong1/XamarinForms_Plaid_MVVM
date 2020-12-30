using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms_Plaid_MVVM.Pages;

namespace XamarinForms_Plaid_MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
