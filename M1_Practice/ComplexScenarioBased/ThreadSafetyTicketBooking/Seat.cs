using System;
namespace ThreadSafetyTicketBooking
{
    public class Seat
    {
        public int SeatNo{get; set;}
        public bool IsBooked{get; set;}
        public string? BookedBy{get; set;}
        public object LockObject{get; set;}

        public Seat(int SeatNo)
        {
            this.SeatNo=SeatNo;
            IsBooked=false;
            LockObject = new object();
        }
    }
}