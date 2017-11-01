using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommunityConnectionPT.Models
{
    public class ApplicationViewModels
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double YearlyIncome { get; set; }
        [Required]
        public string Medicine { get; set; }
        [Required]
        public Insurance Insurance { get; set; }



    }
}