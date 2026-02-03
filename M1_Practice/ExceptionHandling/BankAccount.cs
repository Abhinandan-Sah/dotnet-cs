namespace M1_Practice
{
    public class BankAccount
    {
        public static void Main()
        {
            int balance = 1000;
            Console.WriteLine("Enter withdrawal amount:");
            int amount = int.Parse(Console.ReadLine() ?? "0");

            try
            {
                if (amount <= 0)
                {
                    throw new Exception("Invalid. Negative amount entered");
                }
                else if (amount > balance)
                {
                    throw new Exception("Invalid. withdrawal amount is greater than balance amount");
                }
                else
                {
                    balance -= amount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("---- Transaction Log ----");
                Console.WriteLine("Withdrawal Attempted: " + amount);
                Console.WriteLine("Balance After Transaction: " + balance);
            }
        }
    }
}