using Server.Entity;

namespace Server.DAO;

public class TeacherManagement
{
    private static TeacherManagement instance;
    private static readonly object instancelock = new object();

    public TeacherManagement() { }

    public static TeacherManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new TeacherManagement();
            }
            return instance;
        }
    }

    public Teacher AddTeacher(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public Teacher UpdateTeacher(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public Teacher DeleteTeacher(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Teacher> GetTeachers()
    {
        throw new NotImplementedException();
    }

    public Teacher GetTeacherById(string? id)
    {
        throw new NotImplementedException();
    }

    public Teacher GetTeacherByAccountId(string? id)
    {
        throw new NotImplementedException();
    }
}