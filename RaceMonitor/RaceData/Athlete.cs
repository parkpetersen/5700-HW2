using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceData
{
    class Athlete : Subject
    {
        int BibNumber { get; set; }
        string Firstname { get; set; }
        string LastName { get; set; }
        string Gender { get; set; }
        int Age { get; set; }
    }
}
