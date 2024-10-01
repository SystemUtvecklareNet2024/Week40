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
        /*
         Interface Developer, all Developer-classes that implements this interface must implement
         the methods of this interface.
        */
        void ParticipateInCodingContest(Contest contest);
        void Code();

        /*
         String getFullName is needed because we are using this interface as a data type for a parameter in a method,
         and we need to be able to access the first- and lastname of the object passed as a parameter.
         There are other ways to accomplish this, but they will not be covered in this course.
        */
        string GetFullName();
    }
}
