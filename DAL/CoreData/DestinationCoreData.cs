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
                new Destination { DestinationId = 1, DestinationCity = "Bakı"},
                new Destination { DestinationId = 3, DestinationCity = "Şəki"},
                new Destination { DestinationId = 4, DestinationCity = "Quba"},
                new Destination { DestinationId = 2, DestinationCity = "Qəbələ"},
                new Destination { DestinationId = 5, DestinationCity = "Şuşa"},
                new Destination { DestinationId = 6, DestinationCity = "Lənkəran"},
                new Destination { DestinationId = 7, DestinationCity = "Naftalan"},
                new Destination { DestinationId = 8, DestinationCity = "İsmayıllı"},
                new Destination { DestinationId = 9, DestinationCity = "Qusar"},
                new Destination { DestinationId = 10, DestinationCity = "Zaqatala"}
            );
        }
    }
}