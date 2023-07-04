using Server.Entity;

namespace Server.DAO;

public class GradeManagement
{
    private static GradeManagement instance;
    private static readonly object instancelock = new object();

    public GradeManagement() { }

    public static GradeManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new GradeManagement();
            }
            return instance;
        }
    }

    public Grade AddGrade(Grade grade)
    {
        throw new NotImplementedException();
    }

    public Grade UpdateGrade(Grade grade)
    {
        throw new NotImplementedException();
    }

    public Grade DeleteGrade(Grade grade)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Grade> GetGrades()
    {
        throw new NotImplementedException();
    }

    public Grade GetGradeById(int? id)
    {
        throw new NotImplementedException();
    }
}