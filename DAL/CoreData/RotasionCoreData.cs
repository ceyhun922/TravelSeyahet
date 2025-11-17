using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class RotasionCoreData : IEntityTypeConfiguration<Rotasion>
    {
        public void Configure(EntityTypeBuilder<Rotasion> builder)
        {
            builder.HasData(
                // Bakı turları
                new Rotasion { RotasionID = 1, RotasionName = "Qız Qalası", RotasionDescription = "Bakı İçərişəhərin simvolu, tarixi abidə.", RotasionStatus = true, TourId = 1 },
                new Rotasion { RotasionID = 2, RotasionName = "Şirvanşahlar Sarayı", RotasionDescription = "Orta əsr memarlığının incisi.", RotasionStatus = true, TourId = 1 },
                new Rotasion { RotasionID = 3, RotasionName = "Bulvar Gəzintisi", RotasionDescription = "Xəzər sahili boyunca səyahət və foto çəkilişlər.", RotasionStatus = true, TourId = 2 },
                new Rotasion { RotasionID = 4, RotasionName = "Flame Towers Panorama", RotasionDescription = "Bakı gecəsinin parlayan simvolu.", RotasionStatus = true, TourId = 2 },

                // Qəbələ turları
                new Rotasion { RotasionID = 5, RotasionName = "Tufandağ Kompleksi", RotasionDescription = "Xizək və teleferik macərası.", RotasionStatus = true, TourId = 3 },
                new Rotasion { RotasionID = 6, RotasionName = "Qəbələ Əyləncə Mərkəzi", RotasionDescription = "Qəbələnd əyləncə parkında istirahət.", RotasionStatus = true, TourId = 3 },
                new Rotasion { RotasionID = 7, RotasionName = "Nohur Gölü", RotasionDescription = "Təbiət qoynunda sakitlik və foto turları.", RotasionStatus = true, TourId = 4 },
                new Rotasion { RotasionID = 8, RotasionName = "Yeddi Gözəl Şəlaləsi", RotasionDescription = "Dağlıq ərazidə gəzinti və sərin hava.", RotasionStatus = true, TourId = 4 },

                // Şəki
                new Rotasion { RotasionID = 9, RotasionName = "Xan Sarayı", RotasionDescription = "Şəki xanlarının tarixi iqamətgahı.", RotasionStatus = true, TourId = 5 },
                new Rotasion { RotasionID = 10, RotasionName = "Karvansaray", RotasionDescription = "İpək Yolu üzərində qədim karvansaray kompleksi.", RotasionStatus = true, TourId = 5 },
                new Rotasion { RotasionID = 11, RotasionName = "Kiş Kilsəsi", RotasionDescription = "Qafqazın ən qədim kilsələrindən biri.", RotasionStatus = true, TourId = 5 },

                // Quba
                new Rotasion { RotasionID = 12, RotasionName = "Qəçrəş Meşəsi", RotasionDescription = "Meşəlikdə yürüş və piknik.", RotasionStatus = true, TourId = 6 },
                new Rotasion { RotasionID = 13, RotasionName = "Afurd Şəlaləsi", RotasionDescription = "Təbiətin nadir gözəlliyi, dağlıq ərazi.", RotasionStatus = true, TourId = 6 },
                new Rotasion { RotasionID = 14, RotasionName = "Xınalıq Kəndi", RotasionDescription = "Qafqazın ən qədim yaşayış məskəni.", RotasionStatus = true, TourId = 7 },
                new Rotasion { RotasionID = 15, RotasionName = "Quba Qırmızı Qəsəbə", RotasionDescription = "Unikal yəhudi məhəlləsi və mədəniyyət.", RotasionStatus = true, TourId = 7 },

                // Şuşa
                new Rotasion { RotasionID = 16, RotasionName = "Şuşa Qalası", RotasionDescription = "Qarabağın ürəyində tarixi qala.", RotasionStatus = true, TourId = 8 },
                new Rotasion { RotasionID = 17, RotasionName = "Cıdır Düzü", RotasionDescription = "Qarabağ mənzərələri və açıq hava tədbirləri.", RotasionStatus = true, TourId = 8 },
                new Rotasion { RotasionID = 18, RotasionName = "Gövhər Ağa Məscidi", RotasionDescription = "İslam memarlığının incisi.", RotasionStatus = true, TourId = 8 },

                // Lənkəran
                new Rotasion { RotasionID = 19, RotasionName = "Hirkan Meşəsi", RotasionDescription = "Ekoturizm və dağ yürüşləri.", RotasionStatus = true, TourId = 9 },
                new Rotasion { RotasionID = 20, RotasionName = "Mayak Sahili", RotasionDescription = "Dəniz kənarında gün batımı.", RotasionStatus = true, TourId = 9 },

                // Naftalan
                new Rotasion { RotasionID = 21, RotasionName = "Sanatoriya Kompleksi", RotasionDescription = "Naftalan neft vannası və sağlamlıq mərkəzi.", RotasionStatus = true, TourId = 10 },
                new Rotasion { RotasionID = 22, RotasionName = "Naftalan Parkı", RotasionDescription = "Şəhər parkında istirahət və gəzinti.", RotasionStatus = true, TourId = 10 },

                // İsmayıllı
                new Rotasion { RotasionID = 23, RotasionName = "Lahıc Kəndi", RotasionDescription = "Misgərlik və əl sənətkarlıq mərkəzi.", RotasionStatus = true, TourId = 11 },
                new Rotasion { RotasionID = 24, RotasionName = "Basqal Kəndi", RotasionDescription = "Kənd həyatı və yerli mədəniyyət.", RotasionStatus = true, TourId = 11 },

                // Qusar
                new Rotasion { RotasionID = 25, RotasionName = "Şahdağ Dağ Yolu", RotasionDescription = "Dağ yürüşü və teleferik səyahəti.", RotasionStatus = true, TourId = 12 },
                new Rotasion { RotasionID = 26, RotasionName = "Ləzə Kəndi", RotasionDescription = "Dağlıq kənd həyatı və foto turlar.", RotasionStatus = true, TourId = 12 },

                // Zaqatala
                new Rotasion { RotasionID = 27, RotasionName = "Zaqatala Qalası", RotasionDescription = "Tarixi qala və şəhər mənzərələri.", RotasionStatus = true, TourId = 13 },
                new Rotasion { RotasionID = 28, RotasionName = "Yuxarı Çardaqlar", RotasionDescription = "Mədəni kənd turu və yerli mətbəx.", RotasionStatus = true, TourId = 13 },

                // Qazax
                new Rotasion { RotasionID = 29, RotasionName = "Göyəzən Dağı", RotasionDescription = "Zirvəyə yürüş və mənzərəli foto turları.", RotasionStatus = true, TourId = 14 },
                new Rotasion { RotasionID = 30, RotasionName = "Sınıq Körpü", RotasionDescription = "Tarixi abidə və Qazax çayı ətrafı gəzinti.", RotasionStatus = true, TourId = 16 },
                new Rotasion { RotasionID = 31, RotasionName = "Qazax Qalası", RotasionDescription = "Qazaxın qədim müdafiə istehkamı.", RotasionStatus = true, TourId = 15 }
            );
        }
    }
}
