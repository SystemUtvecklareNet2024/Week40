using OOPDemoIdeaByMarcus.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemoIdeaByMarcus.classes
{
    internal class PythonDeveloper : Employee, IDeveloper
    {
        private string favouriteLanguage = "Python";

        public PythonDeveloper(string firstName, string lastName, bool happy, bool busy, int emplyeeID, int salary) : base(firstName, lastName, happy, busy, emplyeeID, salary)
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
