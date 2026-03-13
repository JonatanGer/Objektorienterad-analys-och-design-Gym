public interface IBookingRepository
{
    void Add(Booking booking);
    void Remove(Booking booking);
    List<Booking> GetBySession(int sessionId);
    List<Booking> GetByMember(int memberId);
}