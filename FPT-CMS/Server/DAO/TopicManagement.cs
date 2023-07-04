using Server.Entity;

namespace Server.DAO;

public class TopicManagement
{
    private static TopicManagement instance;
    private static readonly object instancelock = new object();

    public TopicManagement() { }

    public static TopicManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new TopicManagement();
            }
            return instance;
        }
    }

    public IEnumerable<Topic> GetTopicsByCourseId(string courseId)
    {
        throw new NotImplementedException();
    }

    public Topic GetTopicById(int topicId)
    {
        throw new NotImplementedException();
    }

    public Topic AddTopic(Topic topic)
    {
        throw new NotImplementedException();
    }

    public Topic DeleteTopic(int topicId)
    {
        throw new NotImplementedException();
    }

    public Topic UpdateTopic(Topic topic)
    {
        throw new NotImplementedException();
    }
}