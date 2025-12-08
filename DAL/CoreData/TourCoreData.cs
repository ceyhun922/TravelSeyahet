

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
                new Tour { TourId = 1, TourLocaion = "İçərişəhər tarixi turu", DTourDayNight = "1 Gün", TourPrice = 40, TourCapaCity = 25, TourCountLimit = 5, TourStatus = true, TourDetail = "Bakı İçərişəhərin qədim küçələri və Qız qalası ziyarəti.", TourClock = DateTime.Today.AddHours(9), DestinationId = 1, GuideID = 1, TestimonialID = 1, CommentID = 1, TourImage = "/web/assets/images/g1.jpg", TourRaiting = 5 },
                new Tour { TourId = 2, TourLocaion = "Flame Towers və Bulvar turu", DTourDayNight = "2 Gün 1 Gecə", TourPrice = 85, TourCapaCity = 30, TourCountLimit = 8, TourStatus = true, TourDetail = "Panorama mənzərələri və Xəzər dənizi sahilində gəzinti.", TourClock = DateTime.Today.AddHours(15), DestinationId = 1, GuideID = 2, TestimonialID = 2, CommentID = 2, TourImage = "/web/assets/images/g2.jpg", TourRaiting = 4 },

                // Qəbələ
                new Tour { TourId = 3, TourLocaion = "Tufandağ xizək turu", DTourDayNight = "3 Gün 2 Gecə", TourPrice = 190, TourCapaCity = 20, TourCountLimit = 5, TourStatus = true, TourDetail = "Dağ-xizək istirahəti və Qəbələnin təbiəti.", TourClock = DateTime.Today.AddHours(10), DestinationId = 2, GuideID = 3, TestimonialID = 3, CommentID = 3, TourImage = "/web/assets/images/g3.jpg", TourRaiting = 5 },
                new Tour { TourId = 4, TourLocaion = "Nohur gölü gəzintisi", DTourDayNight = "1 Gün", TourPrice = 50, TourCapaCity = 35, TourCountLimit = 10, TourStatus = true, TourDetail = "Göl ətrafında rahat gəzinti və piknik.", TourClock = DateTime.Today.AddHours(14), DestinationId = 2, GuideID = 4, TestimonialID = 4, CommentID = 4, TourImage = "/web/assets/images/g4.jpg", TourRaiting = 4 },

                // Şəki
                new Tour { TourId = 5, TourLocaion = "Şəki xan sarayı və karvansaray turu", DTourDayNight = "2 Gün 1 Gecə", TourPrice = 110, TourCapaCity = 25, TourCountLimit = 7, TourStatus = true, TourDetail = "Tarixi abidələr və Şəki mətbəxi.", TourClock = DateTime.Today.AddHours(9), DestinationId = 3, GuideID = 5, TestimonialID = 5, CommentID = 5, TourImage = "/web/assets/images/g5.jpg", TourRaiting = 5 },

                // Quba
                new Tour { TourId = 6, TourLocaion = "Qəçrəş meşə turu", DTourDayNight = "1 Gün", TourPrice = 60, TourCapaCity = 40, TourCountLimit = 10, TourStatus = true, TourDetail = "Meşəlikdə yürüş və istirahət.", TourClock = DateTime.Today.AddHours(8), DestinationId = 4, GuideID = 6, TestimonialID = 6, CommentID = 6, TourImage = "/web/assets/images/g6.jpg", TourRaiting = 4 },
                new Tour { TourId = 7, TourLocaion = "Xınalıq kəndi turu", DTourDayNight = "3 Gün 2 Gecə", TourPrice = 220, TourCapaCity = 20, TourCountLimit = 5, TourStatus = true, TourDetail = "Qafqazın ən qədim dağ kəndinə səyahət.", TourClock = DateTime.Today.AddHours(12), DestinationId = 4, GuideID = 7, TestimonialID = 7, CommentID = 7, TourImage = "/web/assets/images/g7.jpg", TourRaiting = 5 },

                // Şuşa
                new Tour { TourId = 8, TourLocaion = "Şuşa qalası və Cıdır düz turu", DTourDayNight = "2 Gün 1 Gecə", TourPrice = 160, TourCapaCity = 20, TourCountLimit = 6, TourStatus = true, TourDetail = "Qarabağın simvolu olan şəhərdə tarixi gəzinti.", TourClock = DateTime.Today.AddHours(10), DestinationId = 5, GuideID = 8, TestimonialID = 8, CommentID = 8, TourImage = "/web/assets/images/g8.jpg", TourRaiting = 5 },

                // Lənkəran
                new Tour { TourId = 9, TourLocaion = "Hirkan Milli Parkı turu", DTourDayNight = "2 Gün 1 Gecə", TourPrice = 130, TourCapaCity = 25, TourCountLimit = 8, TourStatus = true, TourDetail = "Ekoturizm və meşə yürüşləri.", TourClock = DateTime.Today.AddHours(9), DestinationId = 6, GuideID = 9, TestimonialID = 9, CommentID = 9, TourImage = "/web/assets/images/g9.jpg", TourRaiting = 4 },

                // Naftalan
                new Tour { TourId = 10, TourLocaion = "Naftalan sanatoriya istirahəti", DTourDayNight = "3 Gün 2 Gecə", TourPrice = 200, TourCapaCity = 30, TourCountLimit = 10, TourStatus = true, TourDetail = "Müalicəvi neft vannaları və spa xidmətləri.", TourClock = DateTime.Today.AddHours(9), DestinationId = 7, GuideID = 10, TestimonialID = 10, CommentID = 10, TourImage = "/web/assets/images/g10.jpg", TourRaiting = 5 },

                // İsmayıllı
                new Tour { TourId = 11, TourLocaion = "Lahıc kəndi sənətkarlıq turu", DTourDayNight = "1 Gün", TourPrice = 55, TourCapaCity = 30, TourCountLimit = 10, TourStatus = true, TourDetail = "Əl işləri və misgərlik sənəti ilə tanışlıq.", TourClock = DateTime.Today.AddHours(8), DestinationId = 8, GuideID = 3, TestimonialID = 1, CommentID = 11, TourImage = "/web/assets/images/g1.jpg", TourRaiting = 4 },

                // Qusar
                new Tour { TourId = 12, TourLocaion = "Şahdağ xizək kompleksi turu", DTourDayNight = "3 Gün 2 Gecə", TourPrice = 250, TourCapaCity = 25, TourCountLimit = 5, TourStatus = true, TourDetail = "Xizək, dağ yürüşü və qış istirahəti.", TourClock = DateTime.Today.AddHours(11), DestinationId = 9, GuideID = 4, TestimonialID = 2, CommentID = 12, TourImage = "/web/assets/images/g2.jpg", TourRaiting = 5 },

                // Zaqatala
                new Tour { TourId = 13, TourLocaion = "Zaqatala qalası və mədəni tur", DTourDayNight = "2 Gün 1 Gecə", TourPrice = 140, TourCapaCity = 25, TourCountLimit = 6, TourStatus = true, TourDetail = "Tarixi qala və təbiət birləşməsi.", TourClock = DateTime.Today.AddHours(10), DestinationId = 10, GuideID = 5, TestimonialID = 3, CommentID = 13, TourImage = "/web/assets/images/g3.jpg", TourRaiting = 4 },

                // Qazax
                new Tour { TourId = 14, TourLocaion = "Göyəzən dağı turu", DTourDayNight = "1 Gün", TourPrice = 60, TourCapaCity = 30, TourCountLimit = 10, TourStatus = true, TourDetail = "Göyəzən dağının zirvəsinə yürüş və piknik.", TourClock = DateTime.Today.AddHours(8), DestinationId = 11, GuideID = 6, TestimonialID = 4, CommentID = 14, TourImage = "/web/assets/images/g4.jpg", TourRaiting = 5 },
                new Tour { TourId = 15, TourLocaion = "Qazax tarixi abidələr turu", DTourDayNight = "2 Gün 1 Gecə", TourPrice = 125, TourCapaCity = 20, TourCountLimit = 5, TourStatus = true, TourDetail = "Qazaxın qədim məscid və qalaları ilə tanışlıq.", TourClock = DateTime.Today.AddHours(12), DestinationId = 11, GuideID = 7, TestimonialID = 5, CommentID = 15, TourImage = "/web/assets/images/g5.jpg", TourRaiting = 4 },
                new Tour { TourId = 16, TourLocaion = "Sınıq Körpü turu", DTourDayNight = "1 Gün", TourPrice = 45, TourCapaCity = 25, TourCountLimit = 8, TourStatus = true, TourDetail = "Qazaxın simvolik Sınıq Körpüsünü ziyarət.", TourClock = DateTime.Today.AddHours(9), DestinationId = 11, GuideID = 8, TestimonialID = 6, CommentID = 16, TourImage = "/web/assets/images/g6.jpg", TourRaiting = 4 },

                // Əlavə bölgələr
                new Tour { TourId = 17, TourLocaion = "Şuşa şəhər panoraması", DTourDayNight = "1 Gün", TourPrice = 70, TourCapaCity = 25, TourCountLimit = 7, TourStatus = true, TourDetail = "Şuşanın mədəni irsi və mənzərələri.", TourClock = DateTime.Today.AddHours(13), DestinationId = 5, GuideID = 9, TestimonialID = 7, CommentID = 17, TourImage = "/web/assets/images/g7.jpg", TourRaiting = 5 },
                new Tour { TourId = 18, TourLocaion = "İsmayıllı meşə yürüşü", DTourDayNight = "2 Gün 1 Gecə", TourPrice = 120, TourCapaCity = 30, TourCountLimit = 8, TourStatus = true, TourDetail = "Təbiət gəzintiləri və kamp fəaliyyəti.", TourClock = DateTime.Today.AddHours(16), DestinationId = 8, GuideID = 10, TestimonialID = 8, CommentID = 18, TourImage = "/web/assets/images/g8.jpg", TourRaiting = 4 },
                new Tour { TourId = 19, TourLocaion = "Qusar dağ yürüşü", DTourDayNight = "3 Gün 2 Gecə", TourPrice = 210, TourCapaCity = 20, TourCountLimit = 5, TourStatus = true, TourDetail = "Qusar dağları boyunca yürüş və düşərgə.", TourClock = DateTime.Today.AddHours(17), DestinationId = 9, GuideID = 3, TestimonialID = 9, CommentID = 19, TourImage = "/web/assets/images/g9.jpg", TourRaiting = 5 },
                new Tour { TourId = 20, TourLocaion = "Lənkəran çay və qala turu", DTourDayNight = "2 Gün 1 Gecə", TourPrice = 135, TourCapaCity = 25, TourCountLimit = 8, TourStatus = true, TourDetail = "Lənkəran çayı və qədim qalaları ziyarət.", TourClock = DateTime.Today.AddHours(18), DestinationId = 6, GuideID = 2, TestimonialID = 10, CommentID = 20, TourImage = "/web/assets/images/g10.jpg", TourRaiting = 4 }

            );
        }
    }
}
