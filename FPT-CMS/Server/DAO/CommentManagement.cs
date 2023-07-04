using Server.Entity;

namespace Server.DAO;

public class CommentManagement
{
    private static CommentManagement instance;
    private static readonly object instancelock = new object();
    public CommentManagement() { }

    public static CommentManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new CommentManagement();
            }
            return instance;
        }
    }

    public Comment AddComment(Comment comment)
    {
        throw new NotImplementedException();
    }

    public Comment UpdateComment(Comment comment)
    {
        throw new NotImplementedException();
    }

    public Comment DeleteComment(Comment comment)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Comment> GetComments()
    {
        throw new NotImplementedException();
    }

    public Comment GetCommentById(int? id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Comment> GetCommentsByNotification(int notificationId)
    {
        throw new NotImplementedException();
    }
}