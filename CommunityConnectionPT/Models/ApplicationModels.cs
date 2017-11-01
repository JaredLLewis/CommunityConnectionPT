using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityConnectionPT.Models
{
    public class ApplicationModels
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
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