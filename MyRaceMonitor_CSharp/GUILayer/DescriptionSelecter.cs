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
    public partial class DescriptionSelecter : Form
    {
        public DescriptionSelecter(Dictionary<int,Athlete> AthleteList)
        {
            InitializeComponent();
            foreach(int key in AthleteList.Keys)
            {
                ListViewItem item = new ListViewItem(AthleteList[key].BibNumber.ToString()) { Tag = AthleteList[key] };
                AthleteListView.Items.Add(item);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }
            
            
    }
}
