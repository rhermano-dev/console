using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class PersonDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; } = "";
        public int? Age { get; set; }

        public Payroll? PayrollDetail { get; set; }

        public class Payroll
        {
            public int HoursWork { get; set; } = 0;
            public int Rate { get; set; } = 0;
        }

        public void AddPersonDetailsToList(List<PersonDetails> personDetailsList, PersonDetails personDetails)
        { personDetailsList.Add(personDetails); }

        public int CalculatePay(PersonDetails personDetails) => personDetails.PayrollDetail.HoursWork + personDetails.PayrollDetail.Rate;

        public string SetId(int count)
        {
            string id = Id;

            if (count % 2 == 0)
            {
                id = "Divisible by 2";
            }
            else
            {
                id = "Dili";
            }

            return id;
        }
    }
}
