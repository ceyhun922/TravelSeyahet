using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class GuideCoreData : IEntityTypeConfiguration<Guide>
    {
        public void Configure(EntityTypeBuilder<Guide> builder)
        {
            builder.HasData(
                new Guide { GuideID = 1, GuideName = "Ceyhun Əliyev", GuideDescription = "Azərbaycanın tarixi yerləri üzrə ixtisaslaşmış bələdçi.", GuideImage = "/web/assets/images/team1.jpg", GuideStatus = true },
                new Guide { GuideID = 2, GuideName = "Nigar Məmmədova", GuideDescription = "Qəbələ və Şəki bölgələri üzrə təcrübəli bələdçi.", GuideImage = "/web/assets/images/team2.jpg", GuideStatus = true },
                new Guide { GuideID = 3, GuideName = "Rauf Hüseynov", GuideDescription = "Bakı şəhərinin mədəni və memarlıq abidələrini tanıdan peşəkar bələdçi.", GuideImage = "/web/assets/images/team3.jpg", GuideStatus = true },
                new Guide { GuideID = 4, GuideName = "Günel İsmayılova", GuideDescription = "Azərbaycan mətbəxi və ənənələri barədə tur bələdçisi.", GuideImage = "/web/assets/images/team4.jpg", GuideStatus = true },
                new Guide { GuideID = 5, GuideName = "Elvin Rzayev", GuideDescription = "Qarabağ və Şuşa istiqamətində tur rəhbəri.", GuideImage = "/web/assets/images/team1.jpg", GuideStatus = true },
                new Guide { GuideID = 6, GuideName = "Aysel Qasımova", GuideDescription = "Azərbaycanın təbiət parkları və yürüş turları üzrə mütəxəssis.", GuideImage = "/web/assets/images/team2.jpg", GuideStatus = true },
                new Guide { GuideID = 7, GuideName = "Murad Əliyev", GuideDescription = "Qobustan və Abşeron yarımadası üzrə ixtisaslaşmış bələdçi.", GuideImage = "/web/assets/images/team3.jpg", GuideStatus = true },
                new Guide { GuideID = 8, GuideName = "Zəhra Həsənli", GuideDescription = "Mədəni və incəsənət turları üzrə təcrübəli bələdçi.", GuideImage = "/web/assets/images/team4.jpg", GuideStatus = true },
                new Guide { GuideID = 9, GuideName = "Kamal Quliyev", GuideDescription = "İçərişəhər və tarixi Bakı turları üzrə bələdçi.", GuideImage = "/web/assets/images/team1.jpg", GuideStatus = true },
                new Guide { GuideID = 10, GuideName = "Leyla Səlimova", GuideDescription = "Qusar, Quba və Xaçmaz bölgələri üzrə bələdçi.", GuideImage = "/web/assets/images/team2.jpg", GuideStatus = true }
            );

        }
    }
}