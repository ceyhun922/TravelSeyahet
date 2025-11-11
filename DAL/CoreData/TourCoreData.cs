using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class TourCoreData : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasData(
                // Bakı
                new Tour { TourId = 1, TourLocaion = "İçərişəhər turu", TourDetail = "Tarixi şəhər turu", TourClock = DateTime.Today.AddHours(9), DestinationId = 1, GuideID = 1, TestimonialID = 1, TourImage = "/web/assets/images/g1.jpg" },
                new Tour { TourId = 2, TourLocaion = "Dənizkənarı Bulvar turu", TourDetail = "Bulvar gəzintisi", TourClock = DateTime.Today.AddHours(14), DestinationId = 1, GuideID = 2, TestimonialID = 2, TourImage = "/web/assets/images/g2.jpg" },
                new Tour { TourId = 3, TourLocaion = "Flame Towers turu", TourDetail = "Panorama turları", TourClock = DateTime.Today.AddHours(20), DestinationId = 1, GuideID = 3, TestimonialID = 3, TourImage = "/web/assets/images/g3.jpg" },

                // Qəbələ
                new Tour { TourId = 4, TourLocaion = "Tufandağ turu", TourDetail = "Dağ-xizək turu", TourClock = DateTime.Today.AddHours(10), DestinationId = 2, GuideID = 3, TestimonialID = 4, TourImage = "/web/assets/images/g4.jpg" },
                new Tour { TourId = 5, TourLocaion = "Nohur gölü turu", TourDetail = "Göl ətrafında gəzinti", TourClock = DateTime.Today.AddHours(15), DestinationId = 2, GuideID = 4, TestimonialID = 5, TourImage = "/web/assets/images/g5.jpg" },
                new Tour { TourId = 6, TourLocaion = "Qəbələ Qədim şəhəri turu", TourDetail = "Tarixi tur", TourClock = DateTime.Today.AddHours(19), DestinationId = 2, GuideID = 5, TestimonialID = 6, TourImage = "/web/assets/images/g6.jpg" },

                // Şəki
                new Tour { TourId = 7, TourLocaion = "Şəki xan sarayı turu", TourDetail = "Mədəniyyət turu", TourClock = DateTime.Today.AddHours(9), DestinationId = 3, GuideID = 6, TestimonialID = 7, TourImage = "/web/assets/images/g7.jpg" },
                new Tour { TourId = 8, TourLocaion = "Kiş kəndi turu", TourDetail = "Tarixi kilsə turları", TourClock = DateTime.Today.AddHours(13), DestinationId = 3, GuideID = 7, TestimonialID = 8, TourImage = "/web/assets/images/g8.jpg" },
                new Tour { TourId = 9, TourLocaion = "Şəki bazarı turu", TourDetail = "Şirniyyat turu", TourClock = DateTime.Today.AddHours(18), DestinationId = 3, GuideID = 7, TestimonialID = 9, TourImage = "/web/assets/images/g9.jpg" },

                // Quba
                new Tour { TourId = 10, TourLocaion = "Qəçrəş turu", TourDetail = "Meşə turu", TourClock = DateTime.Today.AddHours(8), DestinationId = 4, GuideID = 5, TestimonialID = 10, TourImage = "/web/assets/images/g10.jpg" },
                new Tour { TourId = 11, TourLocaion = "Xınalıq turu", TourDetail = "Dağ kəndi turu", TourClock = DateTime.Today.AddHours(14), DestinationId = 4, GuideID = 8, TestimonialID = 1, TourImage = "/web/assets/images/g1.jpg" },
                new Tour { TourId = 12, TourLocaion = "Qudyalçay turu", TourDetail = "Çay ətrafında gəzinti", TourClock = DateTime.Today.AddHours(19), DestinationId = 4, GuideID = 9, TestimonialID = 2, TourImage = "/web/assets/images/g2.jpg" },

                // Şuşa
                new Tour { TourId = 13, TourLocaion = "Cıdır düz turu", TourDetail = "Tarixi mədəni tur", TourClock = DateTime.Today.AddHours(10), DestinationId = 5, GuideID = 7, TestimonialID = 3, TourImage = "/web/assets/images/g3.jpg" },
                new Tour { TourId = 14, TourLocaion = "Yuxarı Gövhər Ağa məscidi turu", TourDetail = "Mədəni abidələr turu", TourClock = DateTime.Today.AddHours(15), DestinationId = 5, GuideID = 9, TestimonialID = 4, TourImage = "/web/assets/images/g4.jpg" },
                new Tour { TourId = 15, TourLocaion = "Şuşa qalası turu", TourDetail = "Qala turu", TourClock = DateTime.Today.AddHours(20), DestinationId = 5, GuideID = 10, TestimonialID = 5, TourImage = "/web/assets/images/g5.jpg" },

                // Lənkəran
                new Tour { TourId = 16, TourLocaion = "Hirkan Milli Parkı turu", TourDetail = "Ekoturizm", TourClock = DateTime.Today.AddHours(9), DestinationId = 6, GuideID = 9, TestimonialID = 6, TourImage = "/web/assets/images/g6.jpg" },
                new Tour { TourId = 17, TourLocaion = "Mayak sahili turu", TourDetail = "Dəniz gəzintisi", TourClock = DateTime.Today.AddHours(14), DestinationId = 6, GuideID = 10, TestimonialID = 7, TourImage = "/web/assets/images/g7.jpg" },
                new Tour { TourId = 18, TourLocaion = "Lənkəran qalası turu", TourDetail = "Tarixi yerlər turu", TourClock = DateTime.Today.AddHours(19), DestinationId = 6, GuideID = 6, TestimonialID = 8, TourImage = "/web/assets/images/g8.jpg" },

                // Naftalan
                new Tour { TourId = 19, TourLocaion = "Naftalan sanatoriyası turu", TourDetail = "Müalicəvi istirahət", TourClock = DateTime.Today.AddHours(9), DestinationId = 7, GuideID = 10, TestimonialID = 9, TourImage = "/web/assets/images/g9.jpg" },
                new Tour { TourId = 20, TourLocaion = "Naftalan şəhər mərkəzi turu", TourDetail = "Şəhər gəzintisi", TourClock = DateTime.Today.AddHours(13), DestinationId = 7, GuideID = 5, TestimonialID = 10, TourImage = "/web/assets/images/g10.jpg" },
                new Tour { TourId = 21, TourLocaion = "Naftalan parkı turu", TourDetail = "Açıq hava fəaliyyəti", TourClock = DateTime.Today.AddHours(18), DestinationId = 7, GuideID = 5, TestimonialID = 1, TourImage = "/web/assets/images/g1.jpg" },

                // İsmayıllı
                new Tour { TourId = 22, TourLocaion = "Lahıc kəndi turu", TourDetail = "Əl sənətkarlıq turu", TourClock = DateTime.Today.AddHours(8), DestinationId = 8, GuideID = 3, TestimonialID = 2, TourImage = "/web/assets/images/g2.jpg" },
                new Tour { TourId = 23, TourLocaion = "İsmayıllı meşələri turu", TourDetail = "Təbiət gəzintisi", TourClock = DateTime.Today.AddHours(14), DestinationId = 8, GuideID = 5, TestimonialID = 3, TourImage = "/web/assets/images/g3.jpg" },
                new Tour { TourId = 24, TourLocaion = "Basqal kəndi turu", TourDetail = "Mədəni tur", TourClock = DateTime.Today.AddHours(19), DestinationId = 8, GuideID = 3, TestimonialID = 4, TourImage = "/web/assets/images/g4.jpg" },

                // Qusar
                new Tour { TourId = 25, TourLocaion = "Şahdağ turu", TourDetail = "Xizək turu", TourClock = DateTime.Today.AddHours(9), DestinationId = 9, GuideID = 9, TestimonialID = 5, TourImage = "/web/assets/images/g5.jpg" },
                new Tour { TourId = 26, TourLocaion = "Qusar şəhər parkı turu", TourDetail = "Ailəvi istirahət", TourClock = DateTime.Today.AddHours(15), DestinationId = 9, GuideID = 4, TestimonialID = 6, TourImage = "/web/assets/images/g6.jpg" },
                new Tour { TourId = 27, TourLocaion = "Ləzə kəndi turu", TourDetail = "Dağ yürüşü", TourClock = DateTime.Today.AddHours(20), DestinationId = 9, GuideID = 9, TestimonialID = 7, TourImage = "/web/assets/images/g7.jpg" },

                // Zaqatala
                new Tour { TourId = 28, TourLocaion = "Zaqatala qalası turu", TourDetail = "Tarixi tur", TourClock = DateTime.Today.AddHours(9), DestinationId = 10, GuideID = 8, TestimonialID = 8, TourImage = "/web/assets/images/g8.jpg" },
                new Tour { TourId = 29, TourLocaion = "Yuxarı Çardaqlar turu", TourDetail = "Mədəni kənd turu", TourClock = DateTime.Today.AddHours(13), DestinationId = 10, GuideID = 2, TestimonialID = 9, TourImage = "/web/assets/images/g9.jpg" },
                new Tour { TourId = 30, TourLocaion = "Qalal kəndi turu", TourDetail = "Təbiət və mədəniyyət turu", TourClock = DateTime.Today.AddHours(19), DestinationId = 10, GuideID = 1, TestimonialID = 10, TourImage = "/web/assets/images/g10.jpg" }
            );
        }
    }
}
