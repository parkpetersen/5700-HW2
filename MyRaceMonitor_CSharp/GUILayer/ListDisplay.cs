using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer;

namespace GuiLayer
{
    public partial class ListDisplay : AthleteObserver
    {
        public ListDisplay()
        {
            ObservedAthleteList = new List<Athlete>();
            InitializeComponent();
        }

        
        public void RefreshDisplay(Athlete passedAthlete)
        {
            AthleteDisplayView.Items.Clear();
            foreach (Athlete athlete in ObservedAthleteList)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    athlete.BibNumber.ToString(),
                    athlete.FirstName.ToString(),
                    athlete.Lastname.ToString(),
                    athlete.Gender.ToString(),
                    athlete.Age.ToString(),
                    athlete.StartTime.ToString(),
                    athlete.Location.ToString(),
                    athlete.FinishedTime.ToString()
                });
                AthleteDisplayView.Items.Add(item);
            }
        }
    }
}
