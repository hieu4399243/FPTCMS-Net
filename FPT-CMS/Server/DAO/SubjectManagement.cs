using Server.Entity;

namespace Server.DAO;

public class SubjectManagement
{
    private static SubjectManagement instance;
    private static readonly object instancelock = new object();

    public SubjectManagement() { }

    public static SubjectManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new SubjectManagement();
            }
            return instance;
        }
    }

    public Subject AddSubject(Subject subject)
    {
        throw new NotImplementedException();
    }

    public Subject UpdateSubject(Subject subject)
    {
        throw new NotImplementedException();
    }

    public Subject DeleteSubject(Subject subject)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Subject> GetSubjects()
    {
        throw new NotImplementedException();
    }

    public Subject GetSubjectById(string? id)
    {
        throw new NotImplementedException();
    }
}