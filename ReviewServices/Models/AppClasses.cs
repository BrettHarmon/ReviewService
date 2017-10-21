using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewServices.Models.Classes
{
    //[Table = "Series"]
    public class Series
    {

    }

    public class Review
    {
        public int Highest { get; set; } //score denominator
        public int Score { get; set; } //The score out of *highest*
        public string Reviewer { get; set; }
        public string Website { get; set; }
    }
    
    public class Platform
    {
        public string Title { get; set; }

    }
}