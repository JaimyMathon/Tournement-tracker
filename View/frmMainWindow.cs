/* 
    Naam: Jaimy Mathon
    Datum: 04-06-2024
    Klas: IO1S2AV
    Omschrijving: View voor de gehele applicatie
 */

using T8_PraktijkProject.View;

namespace T8_PraktijkProject
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();

            // Open the dashboard page when the application starts
            viewPanel.Controls.Clear();

            frmDashboardWindow dashboard = new frmDashboardWindow();
            dashboard.TopLevel = false;
            viewPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void poulesBtn_Click(object sender, EventArgs e)
        {
            // Open the poules window
            viewPanel.Controls.Clear();

            frmPoulesWindow PoulesWindow = new frmPoulesWindow();
            PoulesWindow.TopLevel = false;
            viewPanel.Controls.Add(PoulesWindow);
            PoulesWindow.Show();
        }

        private void wedstrijdenBtn_Click(object sender, EventArgs e)
        {
            // Open the match window
            viewPanel.Controls.Clear();

            frmWedstrijdView Wedstrijdview = new frmWedstrijdView();
            Wedstrijdview.TopLevel = false;
            viewPanel.Controls.Add(Wedstrijdview);
            Wedstrijdview.Show();
        }

        private void afsluitenBtn_Click(object sender, EventArgs e)
        {
            // Shows a dialog with if i am sure to close
            DialogResult result = MessageBox.Show("Weet je zeker dat je wilt afsluiten?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the result
            if (result == DialogResult.Yes)
            {
                viewPanel.Controls.Clear();
                frmExitWindow exitWindow = new frmExitWindow();
                exitWindow.TopLevel = false;
                viewPanel.Controls.Add(exitWindow);
                exitWindow.Show();
            }
        }

        private void deelnemerBtn_Click(object sender, EventArgs e)
        {
            // Open the poules window
            viewPanel.Controls.Clear();

            frmSpelerView playerView = new frmSpelerView();
            playerView.TopLevel = false;
            viewPanel.Controls.Add(playerView);
            playerView.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Open the login window
            viewPanel.Controls.Clear();

            frmLoginView loginView = new frmLoginView();
            loginView.TopLevel = false;
            viewPanel.Controls.Add(loginView);
            loginView.Show();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            // Open the dashboard window
            viewPanel.Controls.Clear();

            frmDashboardWindow dashboardView = new frmDashboardWindow();
            dashboardView.TopLevel = false;
            viewPanel.Controls.Add(dashboardView);
            dashboardView.Show();
        }
    }
}
