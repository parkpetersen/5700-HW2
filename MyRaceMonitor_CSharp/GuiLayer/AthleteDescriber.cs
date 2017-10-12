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
    public partial class AthleteDescriber : AthleteObserver
    {
        public string description;

        public AthleteDescriber()
        {
            ObservedAthleteList = new List<Athlete>();
            InitializeComponent();
        }

        public virtual void getDescription()
        {
            description = $"Athlete number {ObservedAthleteList[0].BibNumber} description: ";
        }

        public virtual void RegisterWithAthletes()
        {
            foreach(Athlete athlete in ObservedAthleteList)
            {
                athlete.registerObserver(this);
            }
        }

        public override void RefreshObserver()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { RefreshObserver(); });
                return;
            }
            getDescription();
            DescriptionListView.Items.Clear();
            DescriptionListView.Items.Add(description);
        }
    }
}
