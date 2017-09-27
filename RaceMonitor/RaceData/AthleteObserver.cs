using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceData
{
    public class AthleteObserver : Form
    {
        private Dictionary<int, Athlete> ObservedAthletes = new Dictionary<int, Athlete>();

        public void Update(Subject subject)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AthleteObserver
            // 
            this.ClientSize = new System.Drawing.Size(403, 372);
            this.Name = "AthleteObserver";
            this.ResumeLayout(false);

        }
    }
}
