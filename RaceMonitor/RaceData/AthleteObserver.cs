using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceData
{
    class AthleteObserver : Form
    {
        private Dictionary<int, Athlete> ObservedAthletes = new Dictionary<int, Athlete>();

        public void Update(Subject subject)
        {

        }
    }
}
