using DigitalWallet.Core;

namespace DigitalWalletApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string appName= WalletInfo.GetAppName();
            Console.WriteLine(appName);
        }
    }
}