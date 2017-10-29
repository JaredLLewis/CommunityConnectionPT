using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityConnectionPT.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public double YearlyIncome { get; set; }
        public string Medicine { get; set; }
        public Insurance Insurance { get; set; }
        

    }
    public enum Insurance
    {
        Medicare,
        Medicade,
    }
}