using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RaceData;
using RaceData.Messages;

namespace AppLayer
{
    public class DataProcessor : IAthleteUpdateHandler
    {
        ProcessStrategy MyProcessStrategy;
        ProcessStrategyFactory strategyFactory = new ProcessStrategyFactory();
        public static List<Athlete> AthleteList = new List<Athlete>();

        public void ProcessUpdate(AthleteUpdate updateMessage)
        {
            // TODO: Do something to process the update message, depending on the concrete type of message
            MyProcessStrategy = strategyFactory.createProcessStrategy(updateMessage);
            MyProcessStrategy.Process(updateMessage);
            // TODO: Note that the console write line does below here
            //Console.WriteLine(updateMessage.ToString());
            /**
            foreach(Athlete athlete in AthleteList)
            {
                Console.WriteLine(athlete.ToString());
            }
    **/
        }
    }
}
