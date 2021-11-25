using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ISOD_Mobile.Models
{
    public class MyPlan
    {
        public string semester { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string title { get; set; }

        public List<PlanItem> planItems { get; set; }

        public async Task<MyPlan> DownloadPlan(User user)
        {
            var client = new RestClient("https://isod.ee.pw.edu.pl/isod-portal/");
            var request = new RestRequest($"wapi?q=myplan&username={user.Login}&semester={user.PrefferedSemester}&apikey={user.APIKey}", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            
            return (await client.ExecuteAsync<MyPlan>(request)).Data;
        }

    }
}
