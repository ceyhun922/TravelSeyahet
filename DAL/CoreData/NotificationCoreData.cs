using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class NotificationCoreData : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasData(
                new Notification { NotificationId=1, NotificationTitle="Iclas", NotificationDesc="Online Olacaq", NotificationType="warning", NotificationTypeColor="preview-icon bg-success", NotificationTypeIcon="mdi mdi-calendar", NotificationStatus=true},
            );
        }
    }
}