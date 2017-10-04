using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer;
using GuiLayer;

namespace MyRaceMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlForm());
            //ControlForm controlForm = new ControlForm();
            //controlForm.Show();
            //SimulatorController controller = new SimulatorController();
            //controller.Run("../../../SimulationData/Short Race Simulation-01.csv");
        }
    }
}
