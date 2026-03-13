public class BookingService
{
    private IBookingRepository bookingRepository;
    private ITrainingSessionRepository sessionRepository;

    public BookingService(IBookingRepository bookingRepo, ITrainingSessionRepository sessionRepo)
    {
        bookingRepository = bookingRepo;
        sessionRepository = sessionRepo;
    }

    public string BookSession(Member member, int sessionId)
    {
        TrainingSession session = sessionRepository.GetById(sessionId);

        if (session == null)
        {
            return "Passet finns inte.";
        }

        if (session.BookedParticipants >= session.MaxParticipants)
        {
            return "Passet är fullbokat.";
        }

        var existingBookings = bookingRepository.GetByMember(member.MemberId);
        bool alreadyBooked = existingBookings.Any(b => b.SessionId == sessionId);
        if (alreadyBooked)
        {
            return "Du har redan bokat detta pass.";
        }

        Booking booking = new Booking(member.MemberId, sessionId);

        bookingRepository.Add(booking);
        session.BookedParticipants++;

        return "Bokningen genomförd.";
    }

    public string CancelBooking(Member member, int sessionId)
    {
        var bookings = bookingRepository.GetByMember(member.MemberId);

        foreach (var booking in bookings)
        {
            if (booking.SessionId == sessionId)
            {
                bookingRepository.Remove(booking);

                TrainingSession session = sessionRepository.GetById(sessionId);
                session.BookedParticipants--;

                return "Pass avbokat.";
            }
        }

        return "Ingen bokning hittades.";
    }
}