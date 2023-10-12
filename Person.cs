using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Person
    {
        //Egenskaperna som används för klasserna
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }

        public virtual void PrintInfo() //En virtual metod för att kunna skriva om metoderna för vare klass
        {

        }
    }
}
