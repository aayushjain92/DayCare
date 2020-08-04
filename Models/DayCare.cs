using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DayCare.Models
{
    public class DayCare
    {
        private static DayCare dayCare;
        private List<Person> students { get; set; }
        private List<Person> teachers { get; set; }
        private List<Room> rooms { get; set; }

        private DayCare()
        {
            rooms = new List<Room>();
            students = new List<Person>();
            teachers = new List<Person>();

        }

        public static DayCare getInstance()
        {
           
            if (dayCare == null)
            {
                dayCare = new DayCare();
            }

            return dayCare;
        }
    }


}
