using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceData
{
    public class Subject
    {
        public List<AthleteObserver> Subscribers { get; } = new List<AthleteObserver>();

        public void Subscribe(AthleteObserver observer)
        {
            if(observer != null && !Subscribers.Contains(observer))
            {
                Subscribers.Add(observer);
            }
        }

        public void Unsubscribe(AthleteObserver observer)
        {
            if (Subscribers.Contains(observer))
            {
                Subscribers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach(AthleteObserver observer in Subscribers)
            {
                observer.Update();
            }
        }
    }
}
