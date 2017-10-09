using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceData.Messages;

namespace AppLayer
{
    class StartedHandler : ProcessStrategy
    {
        public override void Process(AthleteUpdate updateMessage, Dictionary<int, Athlete> athleteList)
        {
            StartedUpdate update = updateMessage as StartedUpdate;
            athleteList[update.BibNumber].StartTime = update.OfficialStartTime;
            athleteList[update.BibNumber].LastUpdate = update.Timestamp;
            athleteList[update.BibNumber].notifyObservers();
        }
    }
}
