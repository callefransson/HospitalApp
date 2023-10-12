using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Nurse : Person
    {
        //Specifik property för klassen Nurse
        public string Shift { get; set; }
        public Nurse(string name, int age, string gender, string shift)//Konstruktorn
        {
            //Tilldelar namnen
            Name = name;
            Age = age;
            Gender = gender;
            Shift = shift;
        }
        public override void PrintInfo() //Override metod för att skriva om metoden för varje klass
        {
            Console.WriteLine($"Sjuksköterskan heter: {Name}.\n{Name} är {Age} år gammal.\n{Name} är en {Gender}.\n{Name} jobbar {Shift}.");
            Console.WriteLine();
        }
    }
}
