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

        int capacity;

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
            int studentAgeInMonths = ((DateTime.Now.Year - student.dob.Year) * 12) + DateTime.Now.Month - student.dob.Month;

            Boolean assigned = false;
            Person assignedTeacher = null; 
            HashSet<Person> teachers;
            String group = GroupByAge.findGroup(studentAgeInMonths);
            
            if(daycare.groups.TryGetValue(group, out GroupByAge value)) {
                teachers = value.teachers;
            }

            foreach (Person teacher in teachers) {

            }

            if(!assigned)
            {

            }
                
            return assignedTeacher;

        }
    }
}
