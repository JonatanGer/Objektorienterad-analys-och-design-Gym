public class BookingRepository : IBookingRepository
{
    private List<Booking> bookings = new List<Booking>();
   private int nextId = 1;

    public void Add(Booking booking)
    {
        booking.BookingId = nextId++;
        bookings.Add(booking);
    }

    public void Remove(Booking booking)
    {
        bookings.Remove(booking);
    }

    public List<Booking> GetBySession(int sessionId)
    {
        return bookings.Where(b => b.SessionId == sessionId).ToList();
    }

    public List<Booking> GetByMember(int memberId)
    {
        return bookings.Where(b => b.MemberId == memberId).ToList();
    }
}