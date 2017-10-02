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
        public override void Process(AthleteUpdate updateMessage)
        {
            throw new NotImplementedException();
        }
    }
}
