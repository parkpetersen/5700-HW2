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
        public override void Process(AthleteUpdate updateMessage, List<Athlete> athleteList)
        {
            throw new NotImplementedException();
        }
    }
}
