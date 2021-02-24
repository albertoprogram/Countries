using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Countries.Views;

namespace Countries
{
    public partial class App : Application
    {
        #region Constructors
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new LoginPage());
        }
        #endregion

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
