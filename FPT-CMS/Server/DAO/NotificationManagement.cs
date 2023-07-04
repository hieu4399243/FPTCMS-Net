using Server.Entity;

namespace Server.DAO;

public class NotificationManagement
{
    private static NotificationManagement instance;
    private static readonly object instancelock = new object();

    public NotificationManagement() { }

    public static NotificationManagement Instance
    {
        get
        {
            lock (instancelock)
            {
                if (instance == null) instance = new NotificationManagement();
            }
            return instance;
        }
    }

    public Notification AddNotification(Notification notification)
    {
        throw new NotImplementedException();
    }

    public Notification UpdateNotification(Notification notification)
    {
        throw new NotImplementedException();
    }

    public Notification DeleteNotification(Notification notification)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Notification> GetNotifications(string courseId)
    {
        throw new NotImplementedException();
    }

    public Notification GetNotificationById(int? id)
    {
        throw new NotImplementedException();
    }

    public Notification GetNotificationByTopicId(string? accountId, string? courseid)
    {
        throw new NotImplementedException();
    }
}