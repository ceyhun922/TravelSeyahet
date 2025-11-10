using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class DestinationCoreData : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasData(
                new Destination { DestinationId = 1, DestinationCity = "Bakı", DestinationDayNight = "3 gün 2 gecə", DestinationPrice = 350, DestinationImage = "/web/assets/images/g1.jpg", CapaCity = 25, DestinationTime = DateTime.Now, DestinationCountLimit = 30, DestinationStatus = true, GuideID = 1, TestimonialID = 1, UserId = 1 },
                new Destination { DestinationId = 3, DestinationCity = "Şəki", DestinationDayNight = "1 günlük tur", DestinationPrice = 180, DestinationImage = "/web/assets/images/g3.jpg", CapaCity = 15, DestinationTime = DateTime.Now, DestinationCountLimit = 20, DestinationStatus = true, GuideID = 3, TestimonialID = 3, UserId = 3 },
                new Destination { DestinationId = 4, DestinationCity = "Quba", DestinationDayNight = "3 gün 2 gecə", DestinationPrice = 300, DestinationImage = "/web/assets/images/g4.jpg", CapaCity = 20, DestinationTime = DateTime.Now, DestinationCountLimit = 25, DestinationStatus = true, GuideID = 4, TestimonialID = 4, UserId = 1 },
                new Destination { DestinationId = 2, DestinationCity = "Qəbələ", DestinationDayNight = "2 gün 1 gecə", DestinationPrice = 250, DestinationImage = "/web/assets/images/g2.jpg", CapaCity = 20, DestinationTime = DateTime.Now, DestinationCountLimit = 25, DestinationStatus = true, GuideID = 2, TestimonialID = 2, UserId = 2 },
                new Destination { DestinationId = 5, DestinationCity = "Şuşa", DestinationDayNight = "4 gün 3 gecə", DestinationPrice = 400, DestinationImage = "/web/assets/images/g5.jpg", CapaCity = 30, DestinationTime = DateTime.Now, DestinationCountLimit = 30, DestinationStatus = true, GuideID = 5, TestimonialID = 5, UserId = 2 },
                new Destination { DestinationId = 6, DestinationCity = "Lənkəran", DestinationDayNight = "2 gün 1 gecə", DestinationPrice = 270, DestinationImage = "/web/assets/images/g6.jpg", CapaCity = 20, DestinationTime = DateTime.Now, DestinationCountLimit = 25, DestinationStatus = true, GuideID = 6, TestimonialID = 6, UserId = 3 },
                new Destination { DestinationId = 7, DestinationCity = "Naftalan", DestinationDayNight = "3 gün 2 gecə", DestinationPrice = 320, DestinationImage = "/web/assets/images/g7.jpg", CapaCity = 25, DestinationTime = DateTime.Now, DestinationCountLimit = 30, DestinationStatus = true, GuideID = 7, TestimonialID = 7, UserId = 1 },
                new Destination { DestinationId = 8, DestinationCity = "İsmayıllı", DestinationDayNight = "1 günlük tur", DestinationPrice = 190, DestinationImage = "/web/assets/images/g8.jpg", CapaCity = 15, DestinationTime = DateTime.Now, DestinationCountLimit = 20, DestinationStatus = true, GuideID = 8, TestimonialID = 8, UserId = 2 },
                new Destination { DestinationId = 9, DestinationCity = "Qusar", DestinationDayNight = "2 gün 1 gecə", DestinationPrice = 260, DestinationImage = "/web/assets/images/g9.jpg", CapaCity = 20, DestinationTime = DateTime.Now, DestinationCountLimit = 25, DestinationStatus = true, GuideID = 9, TestimonialID = 9, UserId = 3 },
                new Destination { DestinationId = 10, DestinationCity = "Zaqatala", DestinationDayNight = "3 gün 2 gecə", DestinationPrice = 310, DestinationImage = "/web/assets/images/g10.jpg", CapaCity = 25, DestinationTime = DateTime.Now, DestinationCountLimit = 30, DestinationStatus = true, GuideID = 10, TestimonialID = 10, UserId = 1 }
            );
        }
    }
}