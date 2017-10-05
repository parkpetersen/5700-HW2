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
        public List<AthleteObserver> observerList;
        private AthleteObserver _selectedObserver;

        public ControlForm()
        {
            InitializeComponent();
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
                AthleteListLabel.Text = "Athletes:";

            }
            else
            {
                AthleteListLabel.Text = $"Not observed by {_selectedObserver.title}";
                ObservedAthletesLabel.Text = $"Subjects of {_selectedObserver.title}";
            }
            foreach (Athlete athlete in controller.AthleteList)
            {
                ListViewItem item = new ListViewItem(new[]
            {
                    athlete.BibNumber.ToString(),
                    athlete.FirstName.ToString(),
                    athlete.Lastname.ToString(),
                    athlete.Gender.ToString(),
                    athlete.Age.ToString()
                })
                { Tag = athlete };
                if (_selectedObserver != null && athlete.ObserverList.Contains(_selectedObserver))
                {
                    SubscribedListView.Items.Add(item);
                }
                else
                {
                    AthleteListView.Items.Add(item);
                }
            }
        }
            
        /**
        public void RefreshAthleteListView()
        {
            AthleteListView.Items.Clear();
            if (_selectedObserver == null)
            {
                AthleteListLabel.Text = "Athletes:";
                foreach (Athlete athlete in controller.AthleteList)
                {
                    ListViewItem item = new ListViewItem(new[]
                {
                    athlete.BibNumber.ToString(),
                    athlete.FirstName.ToString(),
                    athlete.Lastname.ToString(),
                    athlete.Gender.ToString(),
                    athlete.Age.ToString()
                })
                    { Tag = athlete };
                    AthleteListView.Items.Add(item);
                }
            }
            else
            {
                AthleteListLabel.Text = $"Not observed by {_selectedObserver.title}";
                foreach (Athlete athlete in controller.AthleteList)
                {
                    if (!_selectedObserver.ObservedAthleteList.Contains(athlete))
                    {
                        ListViewItem item = new ListViewItem(new[]
                    {
                    athlete.BibNumber.ToString(),
                    athlete.FirstName.ToString(),
                    athlete.Lastname.ToString(),
                    athlete.Gender.ToString(),
                    athlete.Age.ToString()
                })
                        { Tag = athlete };
                        AthleteListView.Items.Add(item);
                    }
                }
            }

        }

        private void RefreshSubscribedListView()
        {
            SubscribedListView.Items.Clear();

            if(_selectedObserver != null)
            {
                ObservedAthletesLabel.Text = $"Subjects of {_selectedObserver.title}";
                foreach(Athlete athlete in _selectedObserver.ObservedAthleteList)
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                    athlete.BibNumber.ToString(),
                    athlete.FirstName.ToString(),
                    athlete.Lastname.ToString(),
                })
                    { Tag = athlete };
                    SubscribedListView.Items.Add(item);
                }
            }
            else
            {
                SubscribedListView.Items.Clear();
            }
        }
    **/
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
            //RefreshAthleteListView();
            //RefreshSubscribedListView();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();
            observerList = new List<AthleteObserver>();
            controller = new SimulatorController();
            Thread myThread = new Thread(StartSimulation);
            myThread.Start();
         }

        public void StartSimulation()
        {
            controller = new SimulatorController();
            controller.Run("../../../SimulationData/Short Race Simulation-01.csv");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("HI there");
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            AthleteListView.Items.Clear();
            foreach (Athlete athlete in controller.AthleteList)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    athlete.BibNumber.ToString(),
                    athlete.FirstName.ToString(),
                    athlete.Lastname.ToString(),
                    athlete.Gender.ToString(),
                    athlete.Age.ToString()
                })
                { Tag = athlete };
                AthleteListView.Items.Add(item);
            }
        }

        private void ListDisplayButton_Click(object sender, EventArgs e)
        {
            ListDisplay listDisplay = new ListDisplay();
            listDisplay.title = $"Display #{observerList.Count() + 1} (List Display)";
            observerList.Add(listDisplay);
            RefreshObserverListView();
            listDisplay.Show();
        }

        public void RefreshObserverListView()
        {
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
            if(_selectedObserver != null)
            {
                foreach(ListViewItem item in AthleteListView.SelectedItems)
                {
                    Athlete athlete = item.Tag as Athlete;
                    athlete?.registerObserver(_selectedObserver);
                }
                RefreshObserverListView();
                RefreshListViews();
                //RefreshAthleteListView();
            }
        }

        
    }
}
