using Server.Entity;

namespace Server.DAO;

public class DepartmentManagement
{
    private static DepartmentManagement instance;
    private static readonly object instancelock = new object();

    public DepartmentManagement() { }

    public static DepartmentManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new DepartmentManagement();
            }
            return instance;
        }
    }

    public Department AddDepartment(Department department)
    {
        throw new NotImplementedException();
    }

    public Department UpdateDepartment(Department department)
    {
        throw new NotImplementedException();
    }

    public Department DeleteDepartment(Department department)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Department> GetDepartments()
    {
        throw new NotImplementedException();
    }

    public Department GetDepartmentById(int? id)
    {
        throw new NotImplementedException();
    }
}