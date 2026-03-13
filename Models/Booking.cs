public class Booking
{
    public int BookingId { get; set; }
    public int MemberId { get; set; }
    public int SessionId { get; set; }
    public DateTime CreatedAt { get; set; }

    public Booking(/*int bookingId, */int memberId, int sessionId)
    {
        //BookingId = bookingId;
        MemberId = memberId;
        SessionId = sessionId;
        CreatedAt = DateTime.Now;
    }
}