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
                new Rotasion { RotasionID = 1, RotasionName = "Qobustan Qayaüstü", RotasionDescription = "Tarixi abidələrə səyahət", RotasionStatus = true, DestinationId = 1 },
                new Rotasion { RotasionID = 2, RotasionName = "Nohur Gölü", RotasionDescription = "Təbiət gəzintisi və foto turları", RotasionStatus = true, DestinationId = 2 },
                new Rotasion { RotasionID = 3, RotasionName = "Xan Sarayı", RotasionDescription = "Mədəni ekskursiya", RotasionStatus = true, DestinationId = 3 },
                new Rotasion { RotasionID = 4, RotasionName = "Qəçrəş Meşəsi", RotasionDescription = "Dağ yürüşü və piknik", RotasionStatus = true, DestinationId = 4 },
                new Rotasion { RotasionID = 5, RotasionName = "Qalasına Ziyarət", RotasionDescription = "Qarabağın ürəyi olan şəhər", RotasionStatus = true, DestinationId = 5 },
                new Rotasion { RotasionID = 6, RotasionName = "Xalça Müzeyi", RotasionDescription = "Çay bağları və təbiət", RotasionStatus = true, DestinationId = 5 },
                new Rotasion { RotasionID = 7, RotasionName = "Naftalan Müalicə Mərkəzi", RotasionDescription = "Spa və sağlamlıq turu", RotasionStatus = true, DestinationId = 7 },
                new Rotasion { RotasionID = 8, RotasionName = "İsmayıllı Meşələri", RotasionDescription = "Ekoturizm və hiking", RotasionStatus = true, DestinationId = 8 },
                new Rotasion { RotasionID = 9, RotasionName = "Qış Mərkəzi", RotasionDescription = "Qar idmanı və xizək turu", RotasionStatus = true, DestinationId = 9 },
                new Rotasion { RotasionID = 10, RotasionName = "Qoruğ", RotasionDescription = "Təbiət və heyvanat dünyası ilə tanışlıq", RotasionStatus = true, DestinationId = 10 }
            );
        }
    }
}