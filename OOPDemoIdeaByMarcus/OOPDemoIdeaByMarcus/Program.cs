using OOPDemoIdeaByMarcus.classes;

namespace OOPDemoIdeaByMarcus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create employees
            Employee employee1 = new Employee("Bertram", "Gilfoyle", true, true, 1, 40000);
            JavaDeveloper employee2 = new JavaDeveloper("Dinesh", "Chugtai", false, false, 2, 40000);
            DotNetDeveloper employee3 = new DotNetDeveloper("Nelson", "Bighetti", true, false, 3, 30000);
            PythonDeveloper employee4 = new PythonDeveloper("Rickard", "Bernard", true, false, 4, 35000);

            // Create contest
            Contest theContest = new Contest("Pied pipers coding contest 2022", employee1);

            // Greet some people, announce the contest and make som devs enter the contest
            employee1.GreetEveryOne();
            employee2.GreetPerson(employee1);
            employee3.GreetPerson(employee1);
            employee4.GreetPerson(employee1);
            Console.WriteLine("-----------------------------");
            employee1.StartContest(theContest);
            Console.WriteLine("-----------------------------");
            employee2.ParticipateInCodingContest(theContest);
            employee3.ParticipateInCodingContest(theContest);
            employee4.ParticipateInCodingContest(theContest);
            Console.WriteLine("-----------------------------");
            employee1.AnnounceWinnerOfContest(theContest, employee3);
        }
    }
}
