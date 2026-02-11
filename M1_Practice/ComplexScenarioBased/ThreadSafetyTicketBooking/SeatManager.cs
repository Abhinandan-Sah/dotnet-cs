namespace ThreadSafetyTicketBooking
{

    public class SeatManager
    {
        public Dictionary<int, Seat> seats;

        public int totalSeats { get; set; }

        public SeatManager()
        {
            seats = new Dictionary<int, Seat>();
        }

        public void InitilizeSeat(int totalSeats)
        {
            if (totalSeats <= 0)
            {
                throw new ArgumentException("Total Seats should not be Negative");
            }
            this.totalSeats = totalSeats;
            for (int i = 1; i <= totalSeats; i++)
            {
                seats[i] = new Seat(i);
            }
        }


        public bool BookSeat(int seatNo, string userId)
        {
            // Validate userId
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentException("UserId is Invalid");
            }

            // Validate seat exists
            if (!seats.ContainsKey(seatNo))
            {
                throw new Exception("Seat does not exists");
            }

            // Get seat object
            Seat seat = seats[seatNo];

            // Lock that seat
            lock (seat.LockObject)
            {
                // Check if booked
                if (seat.IsBooked)
                {
                    // If booked → return false
                    return false;
                }
                // Else → mark booked
                seat.IsBooked = true;
                // Store bookedBy
                seat.BookedBy = userId;
                // Return true
                return true;
            }

        }

        public Seat GetSeatStatus(int seatNo)
        {
            if (!seats.ContainsKey(seatNo))
            {
                throw new Exception("Seat does not exists");
            }

            return seats[seatNo];
        }

        // Returns list of seats and their status.
        public List<Seat> GetAllSeats()
        {
            return new List<Seat>(seats.Values);
        }

        public bool CancelBooking(int seatNo, string userId)
        {
            if (!seats.ContainsKey(seatNo))
            {
                throw new Exception("Seat does not exists");
            }
            // Validate userId
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentException("UserId is Invalid");
            }

            Seat seat = seats[seatNo];

            lock (seat.LockObject)
            {
                if (!seat.IsBooked)
                {
                    return false;
                }

                if(seat.BookedBy != userId)
                {
                    return false;
                }

                seat.IsBooked=false;
                seat.BookedBy=null;
                return true;

            }
        }
    }
}