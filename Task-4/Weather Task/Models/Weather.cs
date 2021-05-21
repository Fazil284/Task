using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task4b.Models
{
    public class Weather
    {
        [Key]
        public string  City { get; set; }
        public DateTime date { get; set; }
        public double highTemp { get; set; }
        public double lowTemp { get; set; }
        public string forecast { get; set; }
    }
}
