using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceData.Messages;

namespace AppLayer
{
    class LocationHandler : ProcessStrategy
    {
        public override void Process(AthleteUpdate updateMessage, Dictionary<int, Athlete> athleteList)
        {
            LocationUpdate update = updateMessage as LocationUpdate;
            athleteList[update.BibNumber].Location = update.LocationOnCourse;
            athleteList[update.BibNumber].LastUpdate = update.Timestamp;
            athleteList[update.BibNumber].notifyObservers();
        }
    }
}
