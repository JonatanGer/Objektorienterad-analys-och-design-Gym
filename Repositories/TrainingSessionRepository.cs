public class TrainingSessionRepository : ITrainingSessionRepository
{
    private List<TrainingSession> sessions = new List<TrainingSession>();

    public void Add(TrainingSession session)
    {
        sessions.Add(session);
    }

    public TrainingSession GetById(int sessionId)
    {
        return sessions.FirstOrDefault(s => s.SessionId == sessionId);
    }

    public List<TrainingSession> GetAll()
    {
        return sessions;
    }

    public void Remove(int sessionId)
    {
        TrainingSession session = sessions.FirstOrDefault(s => s.SessionId == sessionId);

        if (session != null)
        {
            sessions.Remove(session);
        }
    }
}