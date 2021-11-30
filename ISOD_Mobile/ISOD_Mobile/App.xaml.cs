using System;
using ISOD_Mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ISOD_Mobile
{
    public partial class App : Application
    {
        public static UserData UserData = new UserData();
        
        public App()
        {
            InitializeComponent();

            MainPage = new SplashPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}