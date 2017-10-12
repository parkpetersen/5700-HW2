using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppLayer;
using System.Collections.Generic;

namespace AppTest
{
    [TestClass] //These tests will check various message handlers to ensure that the messages
    public class UnitTest1  //are properly interpreted. It will also indirectly check the 
    {                       //Strategy pattern and Factory patterns used to select a process strategy

        [TestMethod]
        public void RegisterAthleteTest()
        {
            //This test will check if the handler can properly register a new athlete.
            Dictionary<int, Athlete> TestAthleteList = new Dictionary<int, Athlete>();
            int BibNumber = 55;
            string FirstName = "Jim";
            string LastName = "Jameson";
            string Gender = "M";
            int Age = 30;
            Athlete TestAthlete = new Athlete(BibNumber, FirstName, LastName, Gender, Age);
            DataProcessor processor = new DataProcessor();
            processor.ProcessorAthleteList = TestAthleteList;
            string line = $"Registered,{BibNumber},8/15/2017  7:00:00 AM,{FirstName},{LastName},{Gender},{Age}";
            var message = RaceData.Messages.AthleteUpdate.Create(line);
            processor.ProcessUpdate(message);
            Assert.AreEqual(TestAthleteList[55].ToString(), TestAthlete.ToString());
        }

        [TestMethod]
        public void StartedHandlerTest()
        {
            //This test will check if the Started handler works correctly.
            Dictionary<int, Athlete> TestAthleteList = new Dictionary<int, Athlete>();
            int BibNumber = 55;
            string FirstName = "Jim";
            string LastName = "Jameson";
            string Gender = "M";
            int Age = 30;
            Athlete TestAthlete = new Athlete(BibNumber, FirstName, LastName, Gender, Age);
            //when added to List, TestAthlete's start time is default value
            TestAthleteList.Add(BibNumber, TestAthlete);

            DateTime TestStartTime = new DateTime(2017,8,15,7,00,00);
            DataProcessor processor = new DataProcessor();
            processor.ProcessorAthleteList = TestAthleteList;
            string line = $"Started,{BibNumber},{TestStartTime},{TestStartTime}";
            var message = RaceData.Messages.AthleteUpdate.Create(line);
            processor.ProcessUpdate(message); //processor should change TestAthlete's start time
            Assert.AreEqual(TestAthleteList[55].StartTime, TestStartTime); //check

        }

        [TestMethod]
        public void LocationHanderTest()
        {
            //This test will check if the Location handler works correctly.
            Dictionary<int, Athlete> TestAthleteList = new Dictionary<int, Athlete>();
            int BibNumber = 55;
            string FirstName = "Jim";
            string LastName = "Jameson";
            string Gender = "M";
            int Age = 30;
            DateTime TestTimeStamp = new DateTime(2017, 8, 15, 7, 00, 00);
            Athlete TestAthlete = new Athlete(BibNumber, FirstName, LastName, Gender, Age);
            //when added to List, TestAthlete's location is set to 0.
            TestAthleteList.Add(BibNumber, TestAthlete);

            int TestLocation = 1000;
            DataProcessor processor = new DataProcessor();
            processor.ProcessorAthleteList = TestAthleteList;
            string line = $"OnCourse,{BibNumber},{TestTimeStamp},{TestLocation}";
            var message = RaceData.Messages.AthleteUpdate.Create(line);
            processor.ProcessUpdate(message); //processor should change TestAthlete's location
            Assert.AreEqual(TestAthleteList[55].Location, TestLocation); //check
        }

        [TestMethod]
        public void FinishedHandlerTest()
        {
            //This test will check if the Finished handler works correctly.
            Dictionary<int, Athlete> TestAthleteList = new Dictionary<int, Athlete>();
            int BibNumber = 55;
            string FirstName = "Jim";
            string LastName = "Jameson";
            string Gender = "M";
            int Age = 30;
            Athlete TestAthlete = new Athlete(BibNumber, FirstName, LastName, Gender, Age);
            //when added to List, TestAthlete's finish time is default value
            TestAthleteList.Add(BibNumber, TestAthlete);

            DateTime TestFinishTime = new DateTime(2017, 8, 15, 7, 00, 00);
            DataProcessor processor = new DataProcessor();
            processor.ProcessorAthleteList = TestAthleteList;
            string line = $"Started,{BibNumber},{TestFinishTime},{TestFinishTime}";
            var message = RaceData.Messages.AthleteUpdate.Create(line);
            processor.ProcessUpdate(message); //processor should change TestAthlete's start time
            Assert.AreEqual(TestAthleteList[55].StartTime, TestFinishTime); //check
        }
    }
}
