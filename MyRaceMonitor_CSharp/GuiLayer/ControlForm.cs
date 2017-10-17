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
using System.Threading;

namespace GuiLayer
{
    public partial class ControlForm : Form
    {
        public SimulatorController controller;
        public static List<AthleteObserver> observerList;
        private AthleteObserver _selectedObserver = null;
        public static Course myCourse;
        bool active = false;
        //public delegate void RefreshDelegate();

        public ControlForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void RefreshListViews()
        {
            AthleteListView.Items.Clear();
            SubscribedListView.Items.Clear();
            if(_selectedObserver != null)
            {
                AthleteListLabel.Text = "Other Athletes:";
                ObservedAthletesLabel.Text = $"Subjects of {_selectedObserver.title}";

            }
            else
            {
                AthleteListLabel.Text = $"Athletes";
                ObservedAthletesLabel.Text = "No Observer Selected";
            }
            foreach (int athleteKey in controller.AthleteList.Keys)
            {
                ListViewItem item = new ListViewItem(new[]
            {
                    controller.AthleteList[athleteKey].BibNumber.ToString(),
                    controller.AthleteList[athleteKey].FirstName.ToString(),
                    controller.AthleteList[athleteKey].Lastname.ToString(),
                    controller.AthleteList[athleteKey].Gender.ToString(),
                    controller.AthleteList[athleteKey].Age.ToString()
                })
                { Tag = controller.AthleteList[athleteKey] };
                if (_selectedObserver != null && controller.AthleteList[athleteKey].ObserverList.Contains(_selectedObserver))
                {
                    SubscribedListView.Items.Add(item);
                }
                else
                {
                    AthleteListView.Items.Add(item);
                }
            }
        }
            
        
        private void ObserverListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ObserverListView.SelectedIndices.Count == 1)
            {
                _selectedObserver = observerList[ObserverListView.SelectedIndices[0]];
            }
            else
            {
                _selectedObserver = null;
            }
            RefreshListViews();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (ValidateCourseLength())
            {
                active = true;
                StartButton.Hide();
                LengthEntryBox.Hide();
                InstructionLabel.Hide();
                myCourse = new Course(float.Parse(LengthEntryBox.Text, System.Globalization.CultureInfo.InvariantCulture));
                observerList = new List<AthleteObserver>();
                Thread myThread = new Thread(StartSimulation);
                myThread.Start();
                Thread myThread2 = new Thread(RefreshTimer);
                myThread2.Start();
            }
            else
            {
                LengthEntryBox.Clear();
                InstructionLabel.Text = "Must be a number.";
            }
            

         }

        private bool ValidateCourseLength()
        {
            string line = LengthEntryBox.Text;
            float length;
            return float.TryParse(line, out length);
        }

        public void StartSimulation()
        {
            controller = new SimulatorController();
            controller.Run("../../../SimulationData/Century Simulation-01.csv");
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            if (active)
            {
                EmailObserver emailSender = new EmailObserver(controller.AthleteList);
                emailSender.title = $"Display #{observerList.Count() + 1} (Email Observer)";
                observerList.Add(emailSender);
                emailSender.Show();
            }

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (active)
            {
                AthleteListView.Items.Clear();
                foreach (int athleteKey in controller.AthleteList.Keys)
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                    controller.AthleteList[athleteKey].BibNumber.ToString(),
                    controller.AthleteList[athleteKey].FirstName.ToString(),
                    controller.AthleteList[athleteKey].Lastname.ToString(),
                    controller.AthleteList[athleteKey].Gender.ToString(),
                    controller.AthleteList[athleteKey].Age.ToString()
                })
                    { Tag = controller.AthleteList[athleteKey] };
                    AthleteListView.Items.Add(item);
                }
            }
        }

        private void ListDisplayButton_Click(object sender, EventArgs e)
        {
            if (active)
            {
                ListDisplay listDisplay = new ListDisplay();
                listDisplay.title = $"Display #{observerList.Count() + 1} (List Display)";
                observerList.Add(listDisplay);
                RefreshObserverListView();
                listDisplay.Show();
            }
        }

        public void RefreshObserverListView()
        {

            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { RefreshObserverListView(); });
                return;
            }
            ObserverListView.Items.Clear();
            foreach (AthleteObserver observer in observerList)
            {
                ListViewItem observerItem = new ListViewItem(new[]
                {
                    observer.title.ToString()
                });
                ObserverListView.Items.Add(observerItem);
            }

        }

        private void SubScribeButton_Click(object sender, EventArgs e)
        {
            if (active)
            {
                Type type = _selectedObserver.GetType();
                if (_selectedObserver != null && !type.Equals(typeof(EmailObserver)) && !type.Equals(typeof(AthleteDescriber)) && !type.Equals(typeof(AgeDecorator)) && !type.Equals(typeof(NameDecorator)) && !type.Equals(typeof(LocationDecorator)))
                {
                    foreach (ListViewItem item in AthleteListView.SelectedItems)
                    {
                        Athlete athlete = item.Tag as Athlete;
                        athlete?.registerObserver(_selectedObserver);
                    }
                    RefreshObserverListView();
                    RefreshListViews();
                }
                else if (type.Equals(typeof(EmailObserver)) || type.Equals(typeof(AthleteDescriber)) || type.Equals(typeof(AgeDecorator)) || type.Equals(typeof(NameDecorator)) || type.Equals(typeof(LocationDecorator)))
                {
                    ObservedAthletesLabel.Text = $"This type of observer can only observe one athlete.";
                }
            }
        }

        private void UnsubscribeButton_Click(object sender, EventArgs e)
        {
            if (active)
            {
                if (_selectedObserver != null)
                {
                    foreach (ListViewItem item in SubscribedListView.SelectedItems)
                    {
                        Athlete athlete = item.Tag as Athlete;
                        athlete?.removeObserver(_selectedObserver);
                        _selectedObserver.ObservedAthleteList.Remove(athlete);
                    }
                    RefreshObserverListView();
                    RefreshListViews();
                }
            }
        }

        private void RefreshTimer()
        {
            while (true)
            {
                foreach(AthleteObserver observer in observerList)
                {
                    if (observer.updateNeeded)
                    {
                        observer.RefreshObserver();
                    }
                }
                RefreshObserverListView();
                //RefreshListViews();
                Thread.Sleep(1000);
            }
        }

        private void GraphicDisplayButton_Click(object sender, EventArgs e)
        {
            if (active)
            {
                GraphicalDisplay graphicDisplay = new GraphicalDisplay();
                graphicDisplay.title = $"Display #{observerList.Count() + 1} (Graphical Display)";
                observerList.Add(graphicDisplay);
                RefreshObserverListView();
                graphicDisplay.Show();
                graphicDisplay.RefreshObserver();
            }

        }

        private void AthleteDescriptionButton_Click(object sender, EventArgs e)
        {
            if (active)
            {
                DescriptionSelecter selecter = new DescriptionSelecter(controller.AthleteList);
                selecter.Show();
            }
       
        }
    }
}
