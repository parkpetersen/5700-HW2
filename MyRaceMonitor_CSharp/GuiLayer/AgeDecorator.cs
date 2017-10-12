using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppLayer;

namespace GuiLayer
{
    public partial class AgeDecorator : GuiLayer.AthleteDescriber
    {
        AthleteDescriber heldDescriber;

        public AgeDecorator(AthleteDescriber describer)
        {
            heldDescriber = describer;
            ObservedAthleteList = heldDescriber.ObservedAthleteList;

            InitializeComponent();
        }

        public override void getDescription()
        {
            heldDescriber.getDescription();
            this.description = heldDescriber.description + $" Athlete is {ObservedAthleteList[0].Age} years old.";
        }

        public override void RegisterWithAthletes()
        {
            foreach (Athlete athlete in ObservedAthleteList)
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
