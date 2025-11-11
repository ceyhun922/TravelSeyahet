using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class RotasionCoreData : IEntityTypeConfiguration<Rotasion>
    {
        public void Configure(EntityTypeBuilder<Rotasion> builder)
        {
            builder.HasData(
                new Rotasion { RotasionID = 1, RotasionName = "Qobustan Qayaüstü", RotasionDescription = "Tarixi abidələrə səyahət", RotasionStatus = true, TourId = 1 },
                new Rotasion { RotasionID = 2, RotasionName = "Nohur Gölü", RotasionDescription = "Təbiət gəzintisi və foto turları", RotasionStatus = true, TourId = 5 },
                new Rotasion { RotasionID = 3, RotasionName = "Xan Sarayı", RotasionDescription = "Mədəni ekskursiya", RotasionStatus = true, TourId = 7 },
                new Rotasion { RotasionID = 4, RotasionName = "Qəçrəş Meşəsi", RotasionDescription = "Dağ yürüşü və piknik", RotasionStatus = true, TourId = 10 },
                new Rotasion { RotasionID = 5, RotasionName = "Şuşa qalası", RotasionDescription = "Qarabağın ürəyi", RotasionStatus = true, TourId = 15 },
                new Rotasion { RotasionID = 6, RotasionName = "Naftalan Müalicə Mərkəzi", RotasionDescription = "Spa və sağlamlıq turu", RotasionStatus = true, TourId = 19 },
                new Rotasion { RotasionID = 7, RotasionName = "İsmayıllı Meşələri", RotasionDescription = "Ekoturizm və hiking", RotasionStatus = true, TourId = 23 },
                new Rotasion { RotasionID = 8, RotasionName = "Şahdağ Mərkəzi", RotasionDescription = "Qar idmanı və xizək", RotasionStatus = true, TourId = 25 },
                new Rotasion { RotasionID = 9, RotasionName = "Zaqatala Qalası", RotasionDescription = "Tarixi səfər", RotasionStatus = true, TourId = 28 }
            );
        }
    }
}
