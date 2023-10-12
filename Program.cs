using System.ComponentModel;

namespace HospitalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarerar en lista med namn pations som innehåller objekt av klassen Person
            // Lägger till objekt i listan med "new Patient" och skirver ut innehållet som sedan tas upp i konstruktorn
            List<Patient> pations = new List<Patient>
            {
                new Patient("Calle Fransson",25,"Man",false),
                new Patient("Sandra Eriksson", 32, "Kvinna", true)
            };
            List<Nurse> nurses = new List<Nurse> //Skapar en ny lista för klassen Nurse med namn nurses
            {
                new Nurse("Elin Olsson", 30, "Kvinna", "Natt-shift"),
                new Nurse("Sara Fredriksson", 45, "Kvinna", "Dag-shift")
            };
            List<Doctor> doctors = new List<Doctor>//Skapar en ny lista för klassen Doctor med namn doctors
            {
                new Doctor("Aldor Besher", 40, "Man", 45000),
                new Doctor("Reidar Nilsen", 52, "Man", 35000)
            };
            foreach(var person in pations) // Anävnder foreach loop för att skriva ut alla patienter i listan
            {
                //Anropar metoder för att skriva ut infon om patienterna och även om dom är friska eller sjuka
                person.PrintInfo();
                person.TakeBloodTest();
            }
            Console.WriteLine();
            foreach (var person in nurses)
            {
                person.PrintInfo(); // Skriver ut infon om sjuksköterskona 
            }
            Console.WriteLine();
            foreach (var person in doctors)
            {
                person.PrintInfo(); // Skriver ut infon om doktorerna
            }

        }
    }
}