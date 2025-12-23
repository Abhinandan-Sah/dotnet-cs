using CommonLib;
namespace ScienceLib
{
    public class ScienceLib : LoginAbs
    {
        public override bool Login(string username, string password)
        {
            return false;
        }

        public override bool Logout()
        {
            return true;
        }
    }
}