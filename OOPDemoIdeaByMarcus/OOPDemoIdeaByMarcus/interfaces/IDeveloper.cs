using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPDemoIdeaByMarcus.classes;

namespace OOPDemoIdeaByMarcus.interfaces
{
    internal interface IDeveloper
    {
        void ParticipateInCodingContest(Contest contest);
        void Code();
        string GetFullName();
    }
}
