namespace M1_Practice;

class DatabaseConnection
{
    static void Main()
    {
        // TODO:
        // 1. Open connection
        bool connection = false;
        try
        {
            connection = true;
            Console.WriteLine("Connection is open");
            // 2. Simulate operation failure
            throw new Exception("Operation on connection failure");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (connection)
            {
                // 3. Ensure connection is closed properly
                connection = false;
                Console.WriteLine("Database Connection is Closed");

            }
        }
    }
}