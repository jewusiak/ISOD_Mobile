using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ISOD_Mobile.DetailPages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void APIKeyAcceptEntry_OnClicked(object sender, EventArgs e)
        {
            App.UserData.ApiKey = APIKeyEntry.Text;
            App.UserData.Username = UsernameEntry.Text;
            Task.Run(async () =>
            {
                await App.UserData.DownloadPlan();
                Device.BeginInvokeOnMainThread(()=>Application.Current.MainPage=new AppShell());   
            }); 
        }
    }
}