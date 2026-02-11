namespace ThreadSafetyTicketBooking
{
    public class User
    {
        public string UserId{get; set;}
        public string Name{get; set;}
        public int SeatChoice{get; set;}

        public User(string UserId, string Name, int SeatChoice)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.SeatChoice = SeatChoice;
        }
    }
}