using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OOP_Pillars
{
    public class Person
    {
        //State: Store data
        public string Name { get; set; }
        public DateTime BirthDate  { get; set; }

        //Actions: Processes and manipulate data
        public int CalculateAge()
        {
            var currentDate = DateTime.Now;
            var age = currentDate.Year - BirthDate.Year;

            if (currentDate < BirthDate.AddYears(age)) age--;

            return age;
        }
    }
}
