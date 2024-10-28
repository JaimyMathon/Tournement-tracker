/*
 * Author: Rene Kok, Jaimy Mathon
 * Date: 06-06-2024
 * Description: Project Thema 8 Show all matches
*/

using T8_PraktijkProject.Controller;
using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class frmWedstrijdView : Form
    {
        private WedstrijdController wedstrijdController;
            
        public frmWedstrijdView()
        {
            InitializeComponent();
            wedstrijdController = new WedstrijdController();

            // Enable AutoScroll for the FlowLayoutPanel
            wedstrijdFLP.AutoScroll = true;

            // Set the FlowDirection to LeftToRight
            wedstrijdFLP.FlowDirection = FlowDirection.LeftToRight;

            LoadMatches();
        }

        private void LoadMatches()
        {
            List<WedstrijdModel> matches = wedstrijdController.Read();

            foreach (WedstrijdModel match in matches)
            {
                // Show the single match frame
                singleMatchFrame matchFrame = new singleMatchFrame();
                matchFrame.SetMatchData(match);
                wedstrijdFLP.Controls.Add(matchFrame);
            }
        }
    }
}
