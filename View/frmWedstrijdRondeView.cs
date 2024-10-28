/*
 * Author: Rene Kok
 * Date: 16-06-2024
 * Description: Project Thema 8 Wedstrijd View Specifieke Ronde
*/

using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class frmWedstrijdRondeView : Form
    {
            
        public frmWedstrijdRondeView(List<WedstrijdModel> wedstrijden)
        {
            InitializeComponent();

            // Enable AutoScroll for the FlowLayoutPanel
            wedstrijdFLP.AutoScroll = true;

            // Set the FlowDirection to LeftToRight
            wedstrijdFLP.FlowDirection = FlowDirection.LeftToRight;

            LoadMatches(wedstrijden);
        }

        // Load matches function
        private void LoadMatches(List<WedstrijdModel> wedstrijden)
        {
            foreach (WedstrijdModel match in wedstrijden)
            {
                singleMatchFrame matchFrame = new singleMatchFrame();
                matchFrame.SetMatchData(match);
                wedstrijdFLP.Controls.Add(matchFrame);
                //MessageBox.Show(match.Ronde.ToString());
            }
        }
    }
}
