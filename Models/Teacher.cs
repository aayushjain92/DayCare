using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCare.Models
{
    class Teacher : Person
    {
        private static int x = 500101;
        private int id { get; set; }
        public HashSet<Person> students { get; set; }



        public Teacher()
        {
            id = x++;
        }
        
        public Teacher(int id, int age, string fname, string lname)
        {
            this.id = x++;
            this.age = age;
            this.firstName = fname;
            this.lastName = lname;
            
        }

        public override string ToString()
        {
            return $"# {id}";
        }

        public static Person getTeacher(Student student)
        {
            DayCare daycare = DayCare.getInstance();
            
            return null;

        }
    }
}
