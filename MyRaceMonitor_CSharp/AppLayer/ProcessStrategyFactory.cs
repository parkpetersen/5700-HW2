using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceData;
using RaceData.Messages;

namespace AppLayer
{
    class ProcessStrategyFactory
    {
        public ProcessStrategy createProcessStrategy(AthleteUpdate update)
        {
            ProcessStrategy strategy = null;
            if(update.UpdateType == AthleteRaceStatus.Registered)
            {
                strategy = new RegistrationHandler();
            }
            else if(update.UpdateType == AthleteRaceStatus.DidNotStart)
            {
                strategy = new DidNotStartHandler();
            }
            else if (update.UpdateType == AthleteRaceStatus.Started)
            {
                strategy = new StartedHandler();
            }
            else if (update.UpdateType == AthleteRaceStatus.OnCourse)
            {
                strategy = new LocationHandler();
            }
            else if (update.UpdateType == AthleteRaceStatus.DidNotFinish)
            {
                strategy = new DidNotFinishHandler();
            }
            else if (update.UpdateType == AthleteRaceStatus.Finished)
            {
                strategy = new FinishedHandler();
            }

            return strategy;
        }
    }
}
