using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class person
    {

        public string Name { get; set; }   
        public int Age { get; set; }    
        public double Salary { get; set; }  


        public person(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Име : {Name}, Възраст: {Age}, Заплата: {Salary:F2}";
        }

















    }
}
