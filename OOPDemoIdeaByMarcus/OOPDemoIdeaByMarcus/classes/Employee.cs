using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using OOPDemoIdeaByMarcus.abstractclasses;
using OOPDemoIdeaByMarcus.interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPDemoIdeaByMarcus.classes
{
     /*
     Class Employee
     A subclass of Person and baseclass of JavaDeveloper and DotNetDeveloper.
     Adds properties and methods shared by all who are employees.
     Can be initialized into objects.
     */
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

        /*
        This method may require some explanation.
         @param theContest this is an object initialized from the Contest-class. Just as we can pass something of a data type like int or String we can also
        pass an object from a class that we have created.
        */
        public void StartContest(Contest theContest)
        {
            Console.WriteLine($"{FirstName}: 'Im proud to announce {theContest.ContestName}'");
        }



        /*
        This method may require some explanation.It takes two parameters as explained below
        @param theContest se description in the method above...
        @param theDeveloper this is a really nice thing about interfaces. What we are looking to get here is the winner of the contest.But...the winner could be either
        an instance of our class(an object) JavaDeveloper, but it could also, occasionally, be an instance of our DotNetDeveloper class. But both of those
        classes have something in common, they both implement the Developer interface, and we can use the Interface as data type of that parameter.
        Making the method accept an instance of any class(an object) as a parameter as long as it implements the Developer interface.
     
        The first part of the Console.WriteLine is just to type out the name of the one speaking, and that would be the moderator of the contest.
        We have an object (theContest), that object have a property of type Employee as the moderator, so we first get the employee object with theContest.getModerator(),
        then we add .getFirstName() to get the firstName from that Employee-object.
        */
        public void AnnounceWinnerOfContest(Contest theContest, IDeveloper theDeveloper)
        {
            Console.WriteLine($"{theContest.Moderator.FirstName}: 'And the winner of {theContest.ContestName} is {theDeveloper.GetFullName()}'");
        }
    }
}
