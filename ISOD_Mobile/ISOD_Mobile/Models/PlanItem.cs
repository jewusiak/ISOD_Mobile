using System;
using System.Collections.Generic;

namespace ISOD_Mobile.Models
{
    public class PlanItem
    {
        public int id { get; set; }
        public string courseName { get; set; }
        public string courseNumber { get; set; }
        public string courseVersion { get; set; }
        public List<string> teachers { get; set; }
        //public ClassTime startTime { get; set; }
        //public ClassTime endTime { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string dayOfWeek { get; set; }
        public string cycle { get; set; }
        public List<string> groups { get; set; }
        public string building { get; set; }
        public string room { get; set; }
        public string typeOfClasses { get; set; }
        public string buildingShort { get; set; }
        public string cycleShort { get; set; }

       
    }
}
