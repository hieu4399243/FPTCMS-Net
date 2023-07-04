using Server.Entity;

namespace Server.DAO;

public class SubmissionManagement
{
    private static SubmissionManagement instance;
    private static readonly object instancelock = new object();

    public SubmissionManagement() { }

    public static SubmissionManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new SubmissionManagement();
            }
            return instance;
        }
    }

    public Submission AddSubmission(Submission submission)
    {
        throw new NotImplementedException();
    }

    public Submission GetExactSubmission(int topicId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Submission DeleteSubmission(int submissionId)
    {
        throw new NotImplementedException();
    }

    public List<Submission> GetSubmissionsOfTopic(int topicId)
    {
        throw new NotImplementedException();
    }

    public Submission GetSubmissionById(int submissionId)
    {
        throw new NotImplementedException();
    }

    public Submission UpdateSubmission(Submission submission)
    {
        throw new NotImplementedException();
    }
}