using Server.Entity;

namespace Server.DAO;

public class SemesterManagement
{
    private static SemesterManagement instance;
    private static readonly object instancelock = new object();

    public SemesterManagement() { }

    public static SemesterManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new SemesterManagement();
            }
            return instance;
        }
    }

    public Semester AddSemester(Semester semester)
    {
        throw new NotImplementedException();
    }

    public Semester UpdateSemester(Semester semester)
    {
        throw new NotImplementedException();
    }

    public Semester DeleteSemester(Semester semester)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Semester> GetSemesters()
    {
        throw new NotImplementedException();
    }

    public Semester GetSemesterById(string? id)
    {
        throw new NotImplementedException();
    }
}