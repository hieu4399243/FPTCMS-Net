using Server.Entity;

namespace Server.DAO;

public class CurrDetailManagement
{
    private static CurrDetailManagement instance;
    private static readonly object instancelock = new object();

    public CurrDetailManagement() { }

    public static CurrDetailManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new CurrDetailManagement();
            }
            return instance;
        }
    }

    public CurriculumDetail AddCurriculumDetail(CurriculumDetail curriculumDetail)
    {
        throw new NotImplementedException();
    }

    public CurriculumDetail UpdateCurriculumDetail(CurriculumDetail curriculumDetail)
    {
        throw new NotImplementedException();
    }

    public CurriculumDetail DeleteCurriculumDetail(CurriculumDetail curriculumDetail)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CurriculumDetail> GetCurriculumDetails()
    {
        throw new NotImplementedException();
    }

    public CurriculumDetail GetCurriculumDetailById(int? id)
    {
        throw new NotImplementedException();
    }
}