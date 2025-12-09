

using DAL.CoreData;
using Entities.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete
{
    public class Context : IdentityDbContext<Writer, Role, int>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           // önce bağımsızlar
            builder.ApplyConfiguration(new GuideCoreData());
            builder.ApplyConfiguration(new DestinationCoreData());
            builder.ApplyConfiguration(new TestimontalCoreData());

            // sonra Destination'a bağlılar
            builder.ApplyConfiguration(new TourCoreData());
            builder.ApplyConfiguration(new RotasionCoreData());

            // en son bağımsızlar
            builder.ApplyConfiguration(new NotificationCoreData());
            builder.ApplyConfiguration(new SliderCoreData());
/*             builder.ApplyConfiguration(new CommentCoreData()); 
 */
            // İlişkiyi zorla
            builder.Entity<Tour>()
                .HasOne(t => t.Destination)
                .WithMany(d => d.Tours)
                .HasForeignKey(t => t.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);
        }


        public DbSet<About>? Abouts { get; set; }
        public DbSet<Tour>? Tours { get; set; }
        public DbSet<About2>? Abouts2 { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Destination>? Destinations { get; set; }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<Feature2>? Features2 { get; set; }
        public DbSet<Guide>? Guides { get; set; }
        public DbSet<Rezervation>? Rezervations { get; set; }
        public DbSet<Rotasion>? Rotasions { get; set; }
        public DbSet<SubAbout>? SubAbouts { get; set; }
        public DbSet<Testimonial>? Testimonials { get; set; }
        public DbSet<Slider>? Sliders { get; set; }
        public DbSet<Notification>? Notifications { get; set; }

    }

}