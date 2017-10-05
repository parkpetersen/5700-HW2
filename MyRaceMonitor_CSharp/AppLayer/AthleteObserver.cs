using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AppLayer
{ 
    public abstract class AthleteObserver : Form
    {
        bool updateNeeded = false;
        public List<Athlete> ObservedAthleteList;
        private readonly object _myLock = new object();

        public void Notify(Athlete athlete)
        {
            if (!ObservedAthleteList.Contains(athlete))
            {
                ObservedAthleteList.Add(athlete);
            }
            updateNeeded = true;
        }
        public string title = "New Observer.";

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AthleteObserver
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "AthleteObserver";
            this.Load += new System.EventHandler(this.AthleteObserver_Load);
            this.ResumeLayout(false);

        }

        private void AthleteObserver_Load(object sender, EventArgs e)
        {

        }
    }
}
