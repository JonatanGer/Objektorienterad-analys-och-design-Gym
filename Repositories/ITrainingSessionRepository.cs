public interface ITrainingSessionRepository
{
    void Add(TrainingSession session);
    TrainingSession GetById(int sessionId);
    List<TrainingSession> GetAll();
    void Remove(int sessionId);
}