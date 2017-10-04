using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceData.Messages;

namespace AppLayer
{
    class RegistrationHandler : ProcessStrategy
    {
        public override void Process(AthleteUpdate updateMessage, List<Athlete> athleteList)
        {
            Console.WriteLine("Registering new Athlete.");
            RegistrationUpdate regUpdate = updateMessage as RegistrationUpdate;
            Athlete MyNewAthlete = new Athlete(regUpdate.BibNumber, regUpdate.FirstName, regUpdate.LastName, regUpdate.Gender, regUpdate.Age);
            athleteList.Add(MyNewAthlete);
            //Console.WriteLine(updateMessage.ToString());
        }
    }
}
