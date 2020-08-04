using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCare.Models
{
    public class Student : Person
    {
        private static int x = 200101;
        private int id { get; set; }

        private string parent;
        private Person teacher { get; set; }
        private Room room { get; set; }

        public Student() {
            id = x++;
            teacher = assignTeacher();
            room = assignRoom();           
        }

        public Person assignTeacher()
        {
            return Teacher.getTeacher(this);           
        }

        public Room assignRoom()
        {
            return Room.getRoom(this);
        }


        public override string ToString()
        {
            return $"{firstName},{lastName}";
        }
    }
}
