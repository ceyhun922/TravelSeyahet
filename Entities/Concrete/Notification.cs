namespace Entities.Concrete
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationType { get; set; } = string.Empty;
        public string NotificationTypeColor { get; set; }= string.Empty;
        public string NotificationTypeIcon { get; set; } = string.Empty;
        public string NotificationTitle { get; set; }= string.Empty;
        public string NotificationDesc { get; set; }= string.Empty;
        public bool NotificationStatus { get; set; }
    }
}