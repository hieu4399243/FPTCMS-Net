using Server.Entity;

namespace Server.DAO;

public class EnrollmentManagement
{
    private static EnrollmentManagement instance;
    private static readonly object instancelock = new object();

    public EnrollmentManagement() { }

    public static EnrollmentManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new EnrollmentManagement();
            }
            return instance;
        }
    }

    public Enrollment AddEnrollment(Enrollment enrollment)
    {
        throw new NotImplementedException();
    }

    public Enrollment DeleteEnrollment(Enrollment enrollment)
    {
        throw new NotImplementedException();
    }

    public Enrollment GetEnrollmentById(int? id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Enrollment> GetEnrollments()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Enrollment> GetEnrollmentsByCourseId(string? courseId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Enrollment> GetEnrollmentsByStudentId(int? studentId)
    {
        throw new NotImplementedException();
    }
}