namespace M1_Practice;

class ExceptionRethrow
{
    static void Main()
    {
        try
        {
            ProcessData();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid data received in Main");
        }
    }

    static void ProcessData()
    {
        try
        {
            int.Parse("ABC");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format in ProcessData");
            throw; // preserves stack trace
        }
    }
}
