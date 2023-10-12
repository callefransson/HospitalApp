using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Patient : Person 
    {
        // Specifik property för klassen Patient
        public bool IsHealthy { get; set; }
        public Patient(string name, int age, string gender, bool isHealthy) //Konstruktorn
        {
            //Tilldelar namnen
            IsHealthy = isHealthy;
            Name = name;
            Age = age;
            Gender = gender;
        }
        public override void PrintInfo() //Override metod för att skriva om metoden för varje klass
        {
            Console.WriteLine($"Patienten heter: {Name}.\n{Name} är {Age} år gammal.\n{Name} är en {Gender}");
            Console.WriteLine();
        }

        public void TakeBloodTest() //Metod för att se om patienten är sjuk eller inte
        {
            Console.WriteLine("Sjuksköterskan tar blodprov på patienten");
            if (IsHealthy)
            {
                WritePrescription();
                Console.WriteLine();
            }
            else
            {
                WritePrescription();
                Console.WriteLine();
            }
        }
        public void WritePrescription() // Metoden för att skriva ut om patienten behöver medicin och datum för hur länge hen ska ligga inne på sjukhuset
        {
            Console.WriteLine("{0} är {1}", Name, IsHealthy ? "Frisk" : "Sjuk");
            DateTime dateNow = new DateTime(2023, 10, 12); // Använder datatypen DateTime med namn dateNow för att kunna lagra dagens datum
            DateTime dateWhenReleased = dateNow.AddDays(5); // Använder AddDays för att kunna lägga på antal dagar från dagens datum
            if (IsHealthy) // Om patienten är frisk
            {
                Console.WriteLine("{0} är frisk och behöver inte få någon medicin",Name);
                Console.WriteLine("Du blev utskriven: {0:yyyy-MM-dd}", dateNow); //Anropar DateTimes variabelnamn för att skriva ut datumet
            }
            else // Om patienten är sjuk
            {
                Console.WriteLine("{0} är allvarligt sjuk och behöver oppereras..",Name);
                Console.WriteLine("Datumet du blir utskriven är: {0:yyyy-MM-dd}", dateWhenReleased); //Anropar DateTimes variabelnamn för att skriva ut när patienten får åka hem
            }
        }

    }
}
