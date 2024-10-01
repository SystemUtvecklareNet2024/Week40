using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemoIdeaByMarcus.abstractclasses
{
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
