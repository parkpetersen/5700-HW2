using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer
{
    public class Athlete : Subject
    {
        public int BibNumber { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishedTime { get; set; }
        public double Location { get; set; }
        public List<AthleteObserver> ObserverList;
        public DateTime LastUpdate { get; set; }
        public bool DidNotStart = false;
        public bool DidNotFinish = false;

        public Athlete(int bibNum, string fName, string lName, string gender, int age)
        {
            ObserverList = new List<AthleteObserver>();
            BibNumber = bibNum;
            FirstName = fName;
            Lastname = lName;
            Gender = gender;
            Age = age;
            StartTime = new DateTime(1900, 1, 1, 1, 1, 1, 1);
            FinishedTime = new DateTime(1900, 1, 1, 1, 1, 1, 1);
            Location = 0;
            LastUpdate = new DateTime(1900, 1, 1, 1, 1, 1, 1);
        }
        
        public void registerObserver(AthleteObserver observer)
        {
            if(observer != null && !ObserverList.Contains(observer))
            {
                ObserverList.Add(observer);
                observer.Notify(this);
            }
        }

        public void removeObserver(AthleteObserver observer)
        {
            if (ObserverList.Contains(observer))
            {
                ObserverList.Remove(observer);
            }
        }

        public void notifyObservers()
        {
            foreach(AthleteObserver observer in ObserverList)
            {
                observer.Notify(this);
            }
        }

        public virtual Subject Clone()
        {
            return MemberwiseClone() as Subject;
        }

        public override string ToString()
        {
            return $"Bib Number: {BibNumber}, Name: {FirstName} {Lastname}, Gender: {Gender}, Age: {Age}";
        }
    }
}
