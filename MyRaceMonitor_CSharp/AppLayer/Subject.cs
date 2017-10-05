using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer
{
    public interface Subject
    {
        void registerObserver(AthleteObserver observer);
        void removeObserver(AthleteObserver observer);
        void notifyObservers();
    }
}
