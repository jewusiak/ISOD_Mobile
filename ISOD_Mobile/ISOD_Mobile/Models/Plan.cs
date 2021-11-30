using System.Collections.Generic;

namespace ISOD_Mobile.Models
{
    public class Plan
    {
        public string semester { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string title { get; set; }
        public string studentNo { get; set; }
        
        public List<PlanItem> planItems { get; set; }
    }
}