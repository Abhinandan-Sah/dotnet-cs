namespace M1_Practice;

class OrderProcessor
{
    static void Main()
    {
        int[] orders = { 101, -1, 103 };

        // 1. Process each order
        foreach (var order in orders)
        {
            try
            {
                // 2. Throw exception for invalid order ID
                if (order < 0)
                {
                    throw new ArgumentException("Invalid order ID");
                }

                Console.WriteLine($"Order {order} processed successfully");
            }
            // 3. Ensure one failure does not stop processing
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error processing order {order}: {ex.Message}");
            }
        }
    }
}
