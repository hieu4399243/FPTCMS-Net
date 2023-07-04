using Server.Entity;

namespace Server.DAO;

public class CourseManagement
{
    
    private static CourseManagement instance;
    private static readonly object instancelock = new object();

    public CourseManagement()
    {
    }

    public static CourseManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new CourseManagement();
            }

            return instance;
        }
    }

    public Course AddCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public Course UpdateCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public Course DeleteCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Course> GetCourses()
    {
        throw new NotImplementedException();
    }

    public Course GetCourseById(string? id)
    {
        throw new NotImplementedException();
    }

    public Course GetLastCourse()
    {
        throw new NotImplementedException();
    }
}