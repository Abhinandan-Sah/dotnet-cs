namespace CommonLib
{
    public abstract class LoginAbs
    {
        public abstract bool Login(string username, string password);

        public abstract bool Logout();

        public bool IsLoginProcess()
        {
            return true;
        }
    }
}
