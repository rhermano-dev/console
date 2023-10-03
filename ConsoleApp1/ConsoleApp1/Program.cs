using ConsoleApp1.Classes;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonDetails> personDetailsList = new List<PersonDetails>();
            while (true)
            {

                Console.WriteLine("Enter a new Person? [Y/N]");
                string? check = Console.ReadLine();

                if (check == "N" || check == "n")
                {
                    Console.WriteLine("End"); break;
                }
                else if (check == "Y" || check == "y")
                {
                    PersonDetails personDetails = new PersonDetails();

                    personDetails.Id = personDetails.SetId(personDetailsList.Count + 1 );

                    Console.WriteLine("Enter Name: ");
                    personDetails.Name = Console.ReadLine();

                    Console.WriteLine("Enter Address: ");
                    personDetails.Address = Console.ReadLine();

                    Console.WriteLine("Enter Age: ");
                    personDetails.Age = int.Parse(Console.ReadLine());


                    PersonDetails.Payroll payroll = new PersonDetails.Payroll();
                    Console.WriteLine("Enter Hours Worked: ");

                    payroll.HoursWork = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Rate: ");
                    payroll.Rate = int.Parse(Console.ReadLine());

                    personDetails.PayrollDetail = payroll;

                    personDetails.AddPersonDetailsToList(personDetailsList, personDetails);

                    Console.WriteLine("New Record Added!");
                }
                else
                {
                    Console.WriteLine("Unknown Choice"); break;
                }
            }

            Console.WriteLine("==================================");

            personDetailsList.ForEach(x => {
                Console.WriteLine("ID: " + x.Id);
                Console.WriteLine("NAME: " + x.Name);
                Console.WriteLine("ADDRESS: " + x.Address);
                Console.WriteLine("AGE: " + x.Age);
                Console.WriteLine("HOUR WORKED: " + x.PayrollDetail.HoursWork);
                Console.WriteLine("RATE: " + x.PayrollDetail.Rate);
                Console.WriteLine("TOTAL: " + x.CalculatePay(x));
                Console.WriteLine("==================================");
            });
        }
    }
}




