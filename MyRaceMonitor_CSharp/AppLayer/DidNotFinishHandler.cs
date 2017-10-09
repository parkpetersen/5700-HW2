using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceData.Messages;

namespace AppLayer
{
    class DidNotFinishHandler : ProcessStrategy
    {
        public override void Process(AthleteUpdate updateMessage, Dictionary<int, Athlete> athleteList)
        {
            DidNotFinishUpdate update = updateMessage as DidNotFinishUpdate;
            athleteList[update.BibNumber].DidNotFinish = true;
            athleteList[update.BibNumber].LastUpdate = update.Timestamp;
            athleteList[update.BibNumber].notifyObservers();
        }
    }
}
