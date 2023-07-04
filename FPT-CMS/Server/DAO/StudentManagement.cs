using Server.Entity;

namespace Server.DAO;

public class StudentManagement
{
    private static StudentManagement instance;
    private static readonly object instancelock = new object();

    public StudentManagement() { }

    public static StudentManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new StudentManagement();
            }
            return instance;
        }
    }

    public Student AddStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public Student UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public Student DeleteStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Student> GetStudents()
    {
        throw new NotImplementedException();
    }

    public Student GetStudentById(int? id)
    {
        throw new NotImplementedException();
    }

    public Student GetStudentByAccountId(string id)
    {
        throw new NotImplementedException();
    }
}