

using Entities.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete
{
    public class Context : IdentityDbContext<Writer, Role,int>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<About>? Abouts { get; set; }
        public DbSet<About2>? Abouts2 { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Destination>? Destinations { get; set; }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<Feature2>? Features2 { get; set; }
        public DbSet<Guide>? Guides { get; set; }
        public DbSet<Rezervation>? Rezervations { get; set; }
        public DbSet<Rotasion>? Rotasions { get; set; }
        public DbSet<SubAbout>? SubAbouts  { get; set; }
        public DbSet<Testimonial>? Testimonials  { get; set; }
    }
}