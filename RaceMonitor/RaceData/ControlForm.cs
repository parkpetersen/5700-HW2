using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RaceData
{
    public partial class ControlForm : Form
    {
        private Button ListViewButton;
        private ListView ListView;
        SimluatedDataSource DataSource;
        
        private readonly List<Athlete> athletes = new List<Athlete>();

        public ControlForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ListViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewButton
            // 
            this.ListViewButton.Location = new System.Drawing.Point(12, 37);
            this.ListViewButton.Name = "ListViewButton";
            this.ListViewButton.Size = new System.Drawing.Size(130, 29);
            this.ListViewButton.TabIndex = 0;
            this.ListViewButton.Text = "List View";
            this.ListViewButton.UseVisualStyleBackColor = true;
            this.ListViewButton.Click += new System.EventHandler(this.ListViewButton_Click);
            // 
            // ControlForm
            // 
            this.ClientSize = new System.Drawing.Size(338, 294);
            this.Controls.Add(this.ListViewButton);
            this.Name = "ControlForm";
            this.ResumeLayout(false);

        }

        private void ListViewButton_Click(object sender, EventArgs e)
        {
            ListView = new ListView();
            ListView.Show();
            DataSource = new SimluatedDataSource();
            DataSource.InputFilename = "../../../../SimulationData/Short Race Simulation-01";
            
        }
    }
}
