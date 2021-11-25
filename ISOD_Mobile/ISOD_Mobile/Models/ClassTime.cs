using System;
using System.Text.RegularExpressions;

namespace ISOD_Mobile.Models
{
    public class ClassTime
    {
        public TimeSpan Time { get; set; }
        public bool invalid = true;

        public bool FromString(string text)
        {
            if (Regex.IsMatch(text = text.Trim(), @"^(?:1[0-2]|0[0-9]):[0-5][0-9]:[0-5][0-9] ((?:A|P)\.?M\.?)$"))    //Ma format 12-godzinny 12:59:59 AM            
            {
                string[] pcs = text.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Time = new TimeSpan(int.Parse(pcs[0].Trim()) + (pcs[3].Contains("PM") ? 12 : 0), int.Parse(pcs[1].Trim()), int.Parse(pcs[2]));
                invalid = false;
                
            }
            return !invalid;
        }
    }
}
