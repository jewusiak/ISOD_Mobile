using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISOD_Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            ShellContent_mainpage.Icon=ImageSource.FromResource("ISOD_Mobile.Media.home_icon.png", typeof(AppShell).GetTypeInfo().Assembly);
            ShellContent_logout.Icon=ImageSource.FromResource("ISOD_Mobile.Media.logout_icon.png", typeof(AppShell).GetTypeInfo().Assembly);
        }
    }
}