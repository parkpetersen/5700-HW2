using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceData
{
    public class ListView : AthleteObserver
    {
        private System.Windows.Forms.ListView athleteListView;

        public ListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bib Number"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.ButtonFace, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Name"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.ButtonFace, null);
            this.athleteListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // athleteListView
            // 
            this.athleteListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.athleteListView.Location = new System.Drawing.Point(3, 1);
            this.athleteListView.Name = "athleteListView";
            this.athleteListView.Size = new System.Drawing.Size(361, 302);
            this.athleteListView.TabIndex = 0;
            this.athleteListView.UseCompatibleStateImageBehavior = false;
            // 
            // ListView
            // 
            this.ClientSize = new System.Drawing.Size(361, 303);
            this.Controls.Add(this.athleteListView);
            this.Name = "ListView";
            this.ResumeLayout(false);

        }
    }
}
