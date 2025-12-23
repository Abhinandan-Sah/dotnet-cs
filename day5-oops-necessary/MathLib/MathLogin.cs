using CommonLib;
namespace MathLib
{
    public class MathLogin: LoginAbs
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