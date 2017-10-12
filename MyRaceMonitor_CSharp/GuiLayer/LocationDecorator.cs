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
    public partial class LocationDecorator : GuiLayer.AthleteDescriber
    {
        AthleteDescriber heldDescriber;

        public LocationDecorator(AthleteDescriber describer)
        {
            heldDescriber = describer;
            ObservedAthleteList = heldDescriber.ObservedAthleteList;

            InitializeComponent();
        }

        public override void getDescription()
        {
            heldDescriber.getDescription();
            this.description = heldDescriber.description + $" Athlete has traveled {ObservedAthleteList[0].Location} meters.";
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
