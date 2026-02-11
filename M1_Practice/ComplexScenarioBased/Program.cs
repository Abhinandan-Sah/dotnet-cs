using ThreadSafetyTicketBooking;
namespace ComplexScenarioBased
{
    public class Program
    {
        public static void Main()
        {
            SeatManager seatManager = new SeatManager();
            seatManager.InitilizeSeat(1);

            Parallel.For(1, 6, i =>
        {
            try
            {
                bool result = manager.BookSeat(i, "User" + i);
                Console.WriteLine($"User{i}: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User{i} failed: {ex.Message}");
            }
        });


        }
    }
}