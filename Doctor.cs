using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Doctor : Person
    {
        //Specifik property för klassen Doctor
        public int Salary { get; set; }
        public Doctor(string name, int age, string gender, int salary) //Konstruktorn
        {
            //Tilldelar namnen
            Salary = salary;
            Name = name;
            Age = age;
            Gender = gender;
        }
        public override void PrintInfo() //Override metod för att skriva om metoden för varje klass
        {
            Console.WriteLine($"Doktorn heter:{Name}.\n{Name} är {Age}år gammal.\n{Name} är en {Gender}.\n{Name} tjänar {Salary}kr/mån");
            Console.WriteLine();
        }
    }
}
