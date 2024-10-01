using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPDemoIdeaByMarcus.abstractclasses;
using OOPDemoIdeaByMarcus.interfaces;

namespace OOPDemoIdeaByMarcus.classes
{
    internal class Employee : Person
    {
        private int employeeID;
        private int salary;
        public Employee(string firstName, string lastName, bool happy, bool busy) : base(firstName, lastName, happy, busy)
        {
        }
        public Employee(string firstName, string lastName, bool happy, bool busy, int employeeID, int salary) : base(firstName, lastName, happy, busy)
        {
            this.employeeID = employeeID;
            this.salary = salary;
        }

        public void ComplainToBossAboutSalary()
        {
            salary += 1000;
        }

        public void StartContest(Contest theContest)
        {
            Console.WriteLine($"{FirstName}: 'Im proud to announce {theContest.ContestName}'");
        }

        public void AnnounceWinnerOfContest(Contest theContest, IDeveloper theDeveloper)
        {
            Console.WriteLine($"{theContest.Moderator.FirstName}: 'And the winner of {theContest.ContestName} is {theDeveloper.GetFullName()}'");
        }
    }
}
