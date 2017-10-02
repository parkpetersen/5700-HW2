using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer
{
    public class Athlete : Subject
    {
        int BibNumber { get; set; }
        string FirstName { get; set; }
        string Lastname { get; set; }
        string Gender { get; set; }
        int Age { get; set; }
        List<Observer> ObserverList;

        public Athlete(int bibNum, string fName, string lName, string gender, int age)
        {
            ObserverList = new List<Observer>();
            BibNumber = bibNum;
            FirstName = fName;
            Lastname = lName;
            Gender = gender;
            Age = age;
        }
        
        public void registerObserver(Observer observer)
        {
            if(observer != null && !ObserverList.Contains(observer))
            {
                ObserverList.Add(observer);
            }
        }

        public void removeObserver(Observer observer)
        {
            if (ObserverList.Contains(observer))
            {
                ObserverList.Remove(observer);
            }
        }

        public void notifyObservers()
        {
            foreach(Observer observer in ObserverList)
            {
                observer.update(Clone());
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
