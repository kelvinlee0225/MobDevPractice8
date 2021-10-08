using MobDevPractice8.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobDevPractice8
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainTabbedPage();
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
