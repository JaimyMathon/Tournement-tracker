/*
 * Author: Rene Kok
 * Date: 16-06-2024
 * Description: Project Thema 8 Exit Window
*/

using Timer = System.Windows.Forms.Timer;

namespace T8_PraktijkProject.View
{
    public partial class frmExitWindow : Form
    {
        private Timer timer;

        public frmExitWindow()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 3000; // 1 seconde
            timer.Tick += Timer_Tick; // Subscribe op het Tick event
            timer.Start(); // Start de timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop de timer
            timer.Stop();

            // Close je app
            Application.Exit();
        }
    }
}
