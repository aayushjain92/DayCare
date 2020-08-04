using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCare.Models
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public DateTime dob { get; set; } 
        public int phone { get; set; }
        public string email { get; set; }

        public string password { get; set; }


    }
}
