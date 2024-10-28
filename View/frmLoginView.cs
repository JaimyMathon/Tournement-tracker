/*
 * Author: Jaimy Mathon
 * Date: 16-06-2024
 * Description: Project Thema 8 Login window
*/

using T8_PraktijkProject.Controller;
using T8_PraktijkProject.Model;

namespace T8_PraktijkProject.View
{
    public partial class frmLoginView : Form
    {
        private LoginController loginController;

        public frmLoginView()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        // Button for logging into the account
        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Saves the credentials
            string gebruikersnaam = gebruikersnaamInput.Text;
            string wachtwoord = wachtwoordInput.Text;

            // If login is correct
            if (loginController.AuthenticateUser(gebruikersnaam, wachtwoord))
            {
                UserSession.Instance.Login(gebruikersnaam);
                MessageBox.Show("Login succesvol!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Else there is a error
            else
            {
                MessageBox.Show("Ongeldige gebruikersnaam of wachtwoord.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
