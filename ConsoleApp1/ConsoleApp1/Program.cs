using ConsoleApp1.Classes;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    public class PersonDetails
    {
        public string Name { get; set; }
        public string? Address { get; set; } = "";
        public int? Age { get; set; }
        public string Gender { get; set; }
    }

    public class Program
    {
        public bool Function(PersonDetails personDetails)
        {
            // Extracted logic
            Console.WriteLine("==================RESULT==================");

            Console.WriteLine("Hi, " + personDetails.Name);
            Console.WriteLine("You're from, " + personDetails.Address);

            if (personDetails.Age >= 18)
            {
                Console.WriteLine("Legal Age");
            }
            else if (personDetails.Age <= 18 && personDetails.Age >= 0)
            {
                Console.WriteLine("Not legal Age");
            }
            else
            {
                Console.WriteLine("Unkown Input");
                return false;
            }

            switch (personDetails.Gender)
            {
                case "M":
                    Console.WriteLine("Male");
                    break;
                case "F":
                    Console.WriteLine("Female");
                    break;
                default:
                    Console.WriteLine("Unkown Input");
                    return false;

            }

            Console.WriteLine("==================RESULT==================");
            Console.WriteLine(" ==============HAPPY TESTING==============");

            return true;
        }

        static void Main(string[] args)
        {

            Program program = new();
            PersonDetails personDetails = new PersonDetails();

            Console.WriteLine("Enter Name: ");
            personDetails.Name = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            personDetails.Address = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            personDetails.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gender (M/F): ");
            personDetails.Gender = Console.ReadLine();

            program.Function(personDetails);
        }
    }
}