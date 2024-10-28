namespace T8_PraktijkProject.Model
{
    public class UserSession
    {
        private static UserSession _instance;

        // Properties declareren
        public bool IsLoggedIn { get; private set; }
        public string Username { get; private set; }

        private UserSession() { }

        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }

        // logs in a user with username
        public void Login(string username)
        {
            IsLoggedIn = true;
            Username = username;
        }
    }
}
