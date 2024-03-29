﻿using System.Collections.Generic;
using System.Threading;
using RaceData;

namespace AppLayer
{
    public class SimulatorController
    {
        private SimulatedDataSource _simluatedData;
        public Dictionary<int,Athlete> AthleteList;
        public void Run(string inputFileName)
        {
            DataProcessor handler = new DataProcessor();
            AthleteList = new Dictionary<int, Athlete>();
            handler.ProcessorAthleteList = AthleteList;
            _simluatedData = new SimulatedDataSource()
            {
                InputFilename = inputFileName,
                Handler = handler
            };

            _simluatedData.Start();

            // Let the simulator run for 3 minutes
            Thread.Sleep(1800000000);

            _simluatedData.Stop();
        }
    }
}
