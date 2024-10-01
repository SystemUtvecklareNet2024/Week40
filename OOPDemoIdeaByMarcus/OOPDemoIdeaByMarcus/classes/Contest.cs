using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemoIdeaByMarcus.classes
{
    internal class Contest
    {
        public string ContestName { get; set; }
        public Employee Moderator { get; set; }

        public Contest(string contestName, Employee moderator)
        {
            this.ContestName = contestName;
            this.Moderator = moderator;
        }
    }
}
