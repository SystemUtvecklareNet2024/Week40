using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPDemoIdeaByMarcus.interfaces;

namespace OOPDemoIdeaByMarcus.classes
{
    internal class DotNetDeveloper : Employee, IDeveloper
    {
        private string favouriteLanguage = "C#";

        public DotNetDeveloper(string firstName, string lastName, bool happy, bool busy, int emplyeeID, int salary) : base(firstName, lastName, happy, busy, emplyeeID, salary)
        {
        }

        public void Code()
        {
            Console.WriteLine($"{FirstName} starts writing beautiful {favouriteLanguage} code..");
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void ParticipateInCodingContest(Contest contest)
        {
            Console.WriteLine($"{FirstName} starts to create an amazing {favouriteLanguage}-app to win the {contest.ContestName}");
        }
    }
}
