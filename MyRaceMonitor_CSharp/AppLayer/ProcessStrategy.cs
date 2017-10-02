using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceData;
using RaceData.Messages;

namespace AppLayer
{
    public abstract class ProcessStrategy
    {
        public abstract void Process(AthleteUpdate updateMessage);
    }
}
