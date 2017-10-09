using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceData.Messages;

namespace AppLayer
{
    class DidNotStartHandler : ProcessStrategy
    {
        public override void Process(AthleteUpdate updateMessage, Dictionary<int, Athlete> athleteList)
        {
            DidNotStartUpdate update = updateMessage as DidNotStartUpdate;
            athleteList[update.BibNumber].DidNotStart = true;
            athleteList[update.BibNumber].LastUpdate = update.Timestamp;
            athleteList[update.BibNumber].notifyObservers();
        }
    }
}
