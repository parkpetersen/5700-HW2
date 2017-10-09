using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceData.Messages;

namespace AppLayer
{
    class FinishedHandler : ProcessStrategy
    {
        public override void Process(AthleteUpdate updateMessage, Dictionary<int, Athlete> athleteList)
        {
            FinishedUpdate update = updateMessage as FinishedUpdate;
            athleteList[update.BibNumber].FinishedTime = update.OfficialEndTime;
            athleteList[update.BibNumber].LastUpdate = update.Timestamp;
            athleteList[update.BibNumber].notifyObservers();
        }
    }
}
