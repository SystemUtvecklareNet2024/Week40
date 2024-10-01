using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemoIdeaByMarcus.abstractclasses
{
     /*
     Abstract class Person
     An abstract class can not be initialized into an object. In our case, this class consist of some properties
     and methods that every Person shares. It will be the baseclass of Employee. If the application would later
     have a class for customer, then it could be a base of Person as well. That is why we use this instead of
     putting the properties and methods of Person into the Employee class.
     */
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Happy { get; set; }
        public bool Busy { get; set; }

        protected Person(string firstName, string lastName, bool happy, bool busy)
        {
            FirstName = firstName;
            LastName = lastName;
            Happy = happy;
            Busy = busy;
        }

        public void PresentSelf()
        {
            Console.WriteLine($"{FirstName}: 'My name is {FirstName} {LastName}'");
        }

        public void GreetEveryOne()
        {
            Console.WriteLine($"{FirstName}: 'Hello everyone'");
        }

        public void GreetPerson(Person thePersonToGreet)
        {
            Console.WriteLine($"{FirstName}: 'Hi there {thePersonToGreet.FirstName}'");
        }
    }
}
