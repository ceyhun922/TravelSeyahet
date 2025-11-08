using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class SliderCoreData : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasData(
                new Slider { SliderId=1, SliderBanner="/web/assets/images/banner1.jpg", SliderTitle1="Seyahetin Dadını Çıxart",SliderTitle2="Dünyaya Ferqli Bax", SliderStatus=true}
            );
        }
    }
}