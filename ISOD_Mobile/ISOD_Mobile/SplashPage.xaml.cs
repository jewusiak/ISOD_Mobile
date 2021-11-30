using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ISOD_Mobile
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            splashLogo.Source= ImageSource.FromResource("ISOD_Mobile.Media.EE-logo.png", typeof(SplashPage).GetTypeInfo().Assembly);
            Task.Run(async () =>
            {
                Thread.Sleep(2000);
                if (!await App.UserData.IsApiKeyAndLoginSet())
                    Device.BeginInvokeOnMainThread(() => Application.Current.MainPage = new DetailPages.LoginPage());
                else
                {
                    await App.UserData.DownloadPlan();
                    Device.BeginInvokeOnMainThread(() => Application.Current.MainPage=new AppShell());
                }
            });
        }
    }
}