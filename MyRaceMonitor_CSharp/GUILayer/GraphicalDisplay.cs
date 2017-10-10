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
    public partial class GraphicalDisplay : AthleteObserver
    {
        public GraphicalDisplay()
        {
            InitializeComponent();
            ObservedAthleteList = new List<Athlete>();
        }

        public static readonly Color[] Colors = new Color[]
        {
            Color.Red,
            Color.Blue,
            Color.ForestGreen,
            Color.PaleVioletRed,
            Color.Orchid,
            Color.Aquamarine,
            Color.Aqua,
            Color.Bisque,
            Color.Blue,
            Color.BlueViolet,
            Color.Brown,
            Color.BurlyWood,
            Color.CadetBlue,
            Color.Chocolate,
            Color.Coral,
            Color.CornflowerBlue,
            Color.Crimson,
            Color.DarkBlue,
            Color.DarkCyan,
            Color.DarkGoldenrod,
            Color.DarkGreen,
            Color.DarkKhaki,
            Color.DarkOrange,
            Color.DarkOrchid,
            Color.DarkSalmon,
            Color.DarkSeaGreen,
            Color.DarkTurquoise,
            Color.DeepSkyBlue,
            Color.DodgerBlue,
            Color.ForestGreen,
            Color.Gold,
            Color.Goldenrod,
            Color.Green,
            Color.GreenYellow,
            Color.IndianRed,
            Color.Khaki,
            Color.LightGreen
        };
        public override void RefreshObserver()
        {

            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { RefreshObserver(); });
                return;
            }
            Pen pen = new Pen(Color.Black);
            Graphics graphics = boxPanel.CreateGraphics();
            graphics.Clear(Color.White);

            float startX = 20;
            float startY = boxPanel.Height / 2;
            float endX = boxPanel.Width - 20;
            float endY = boxPanel.Height / 2;
            float courseLength = ControlForm.myCourse.CourseLength;
            float lineLength = endX - startX;

            graphics.DrawLine(pen, startX, startY, endX, endY);
            graphics.DrawLine(pen, startX, startY - 20, startX, startY + 20);
            graphics.DrawLine(pen, endX, endY - 20, endX, endY + 20);
            //StartLabel.Text = "0";
            //FinishLabel.Text = $"{length}";
            ColorKeyListView.Items.Clear();
            foreach (Athlete athlete in ObservedAthleteList)
            {
                float lineLocation = Convert.ToSingle(athlete.Location) / (courseLength / lineLength);
                pen.Color = Colors[athlete.BibNumber % Colors.Length];
                graphics.DrawLine(pen, startX + lineLocation, startY - 10, startX + lineLocation, startY + 10);
                ListViewItem item = new ListViewItem(new[]
                {
                    athlete.BibNumber.ToString(),
                    pen.Color.ToString()
                });
                ColorKeyListView.Items.Add(item);
            }
        }
    }
}
