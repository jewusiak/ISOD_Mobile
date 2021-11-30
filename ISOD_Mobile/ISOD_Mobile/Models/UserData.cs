using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ISOD_Mobile.Models
{
    public class UserData
    {
        public Plan Plan { get; set; }

        //Przeniesione z klasy User

        private string _apiKey;

        public string ApiKey
        {
            get => _apiKey;
            set
            {
                _apiKey = value;
                SecureStorage.SetAsync("ApiKey", _apiKey);
            }
        }
        
        private string _username;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                SecureStorage.SetAsync("Username", _username);
            }
        }

        private string _preferredSemester;

        public string PreferredSemester
        {
            get
            {
                if (string.IsNullOrEmpty(_preferredSemester))
                {
                    _preferredSemester = SecureStorage.GetAsync("PreferredSemester").Result;
                    if (_preferredSemester==null)
                    {
                        int month = int.Parse(DateTime.Now.ToString("MM"));
                        _preferredSemester = DateTime.Now.ToString("yyyy") + (month < 2 || month > 7 ? "Z" : "L");
                        SecureStorage.SetAsync("PreferredSemester", _preferredSemester);
                    }
                }

                return _preferredSemester;
            }
            set
            {
                _preferredSemester = value;
                SecureStorage.SetAsync("PreferredSemester", _preferredSemester);
            }
        }

        

        public async Task<bool> IsApiKeyAndLoginSet()
        {
            ApiKey = await SecureStorage.GetAsync("ApiKey");
            Username = await SecureStorage.GetAsync("Username");
            if (ApiKey == null || Username == null)
                return false;
            return true;
        }

        public async Task DownloadPlan()
        {
            var client = new RestClient("https://isod.ee.pw.edu.pl/isod-portal/");
            var request =
                new RestRequest($"wapi?q=myplan&username={Username}&semester={PreferredSemester}&apikey={ApiKey}",
                    Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            Plan = (await client.ExecuteAsync<Plan>(request)).Data;

            
        }
    }
}