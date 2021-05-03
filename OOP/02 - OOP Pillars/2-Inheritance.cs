using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OOP_Pillars
{
    /// <summary>
    /// Inheritance: Absorbs the state and actions of a class
    /// An Employee is a Person
    /// </summary>
    public class Employee : Person
    {
        public DateTime AdmissionDate { get; set; }
        public string Registry { get; set; }
    }

    public class Process
    {
        public void Execution()
        {
            var employee = new Employee()
            {
                Name = "Thiago Mustafá",
                BirthDate = Convert.ToDateTime("1994/11/09"),
                AdmissionDate = DateTime.Now,
                Registry = "003285",
            };
        }
    }
}
