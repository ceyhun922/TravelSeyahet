

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class TestimontalCoreData : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasData(
                new Testimonial { TestimonialID = 1, TestimonialClient = "Eldar Nəsibov", TestimonialComment = "Tur zamanı hər şey əla idi!", TestimonialImage = "/web/assets/images/test1.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 2, TestimonialClient = "Ləman Abbasova", TestimonialComment = "Bələdçilər çox mehriban idi.", TestimonialImage = "/web/assets/images/test2.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 3, TestimonialClient = "Kənan Quliyev", TestimonialComment = "Maraqlı və rahat səyahət idi.", TestimonialImage = "/web/assets/images/test3.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 4, TestimonialClient = "Aytac Nəbiyeva", TestimonialComment = "Qrup şəklində çox gözəl təşkil olunmuşdu.", TestimonialImage = "/web/assets/images/test4.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 5, TestimonialClient = "Rəşad Məmmədli", TestimonialComment = "Foto məkanlar möhtəşəm idi.", TestimonialImage = "/web/assets/images/test5.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 6, TestimonialClient = "Sevda Həsənova", TestimonialComment = "Ən sevdiyim tur agentliyidir!", TestimonialImage = "/web/assets/images/test6.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 7, TestimonialClient = "Orxan Əliyev", TestimonialComment = "Qarabağ turu inanılmaz idi.", TestimonialImage = "/web/assets/images/test7.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 8, TestimonialClient = "Aysel Qasımova", TestimonialComment = "Təbiət yürüşü çox zövqlü keçdi.", TestimonialImage = "/web/assets/images/test8.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 9, TestimonialClient = "Murad Hüseynov", TestimonialComment = "Təşkilatçılıq yüksək səviyyədə idi.", TestimonialImage = "/web/assets/images/test9.jpg", TestimonialStatus = true },
                new Testimonial { TestimonialID = 10, TestimonialClient = "Nigar Məmmədli", TestimonialComment = "Gələn dəfə də sizlərlə gedəcəm!", TestimonialImage = "/web/assets/images/test10.jpg", TestimonialStatus = true }
            );

        }
    }
}