using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCare.Models
{
    public class Room
    {
        private static int x = 1;

        private string id{ get; set; }

        private HashSet<Person> teachers { get; set; }

        int capacity;
        
        public Room()
        {

            id = "Room_" + x++;
            teachers = new HashSet<Person>();
            capacity = -1;
        }


        public override string ToString()
        {
            return $"Room number = {id}";
        }
    }
}
