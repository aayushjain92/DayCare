

using System;
using System.Collections.Generic;
using System.IO;

namespace DayCare.Models
{
    public class ImmunizationReminder
    {
        public ImmunizationReminder()
        {
            readFile();
        }

        //read the studentImmune file and take date of birth


        static string path = @"./studentImmune.csv";
        public String[] str;
        public DateTime date_of_birth;
        public void readFile()
        {

            if (File.Exists(path))
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    string s;

                    while ((s = sr.ReadLine()) != null)
                    {
                        str = s.Split(",");
                        date_of_birth = Convert.ToDateTime(str[5]);
                    }
                }
            }

            reminder(date_of_birth);
        }

        public void reminder(DateTime dob)
        {
            int years = DateTime.Now.Year - dob.Year;
            dob = dob.AddYears(years);
            DateTime check = DateTime.Now.AddMonths(1);
            if (check >= dob && dob > DateTime.Now)
            {
                if (File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("HappyBirthday Nupuu");
                    }
                }

            }
        }
    }
}
