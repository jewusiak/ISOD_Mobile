using System;
using System.Collections.Generic;
using System.Text;

namespace ISOD_Mobile.Models
{
    public class User
    {
        
        public string APIKey { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PrefferedSemester = DateTime.Now.ToString("yyyy") + "Z"; //TODO: wybór semestru
        public bool IsAuthenticated { get; set; }

        
        public void getAuth()
        {
            if(App.Current.Properties.TryGetValue("APIKey", out object _apikey))
                APIKey = _apikey.ToString();
            else
            {

            }

        }
    }
}
