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

        public ControlForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void RefreshAthleteListView()
        {
            AthleteListView.Items.Clear();
            foreach (Athlete athlete in controller.AthleteList)
            {
                ListViewItem item = new ListViewItem(new[] { athlete.ToString() });
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();
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
                });
                AthleteListView.Items.Add(item);
            }
        }
    }
}
