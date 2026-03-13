public class TrainingSession
{
    public int SessionId { get; set; }
    public string Title { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int MaxParticipants { get; set; }
    public int BookedParticipants { get; set; }

    public TrainingSession(int sessionId, string title, DateTime startTime, DateTime endTime, int maxParticipants)
    {
        SessionId = sessionId;
        Title = title;
        StartTime = startTime;
        EndTime = endTime;
        MaxParticipants = maxParticipants;
        BookedParticipants = 0;
    }

    public int GetAvailableSpots()
    {
        return MaxParticipants - BookedParticipants;
    }
}