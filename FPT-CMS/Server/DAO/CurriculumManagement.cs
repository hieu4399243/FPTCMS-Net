using Server.Entity;

namespace Server.DAO;

public class CurriculumManagement
{
    private static CurriculumManagement instance;
    private static readonly object instancelock = new object();

    public CurriculumManagement() { }

    public static CurriculumManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new CurriculumManagement();
            }
            return instance;
        }
    }


    public Curriculum AddCurriculum(Curriculum curriculum)
    {
        throw new NotImplementedException();
    }

    public Curriculum UpdateCurriculum(Curriculum curriculum)
    {
        throw new NotImplementedException();
    }

    public Curriculum DeleteCurriculum(Curriculum curriculum)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Curriculum> GetCurriculums()
    {
        throw new NotImplementedException();
    }

    public Curriculum GetCurriculumById(int? id)
    {
        throw new NotImplementedException();
    }
}