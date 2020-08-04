using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCare.Models
{
    public class Student : Person
    {
        public static int x = 200101;
        public int id { get; set; }
        public string parent;

        public Student() {
            id = x++;
        }


        public override string ToString()
        {
            return $"{firstName},{lastName}";
        }
    }
}
