using Microsoft.EntityFrameworkCore;
using Instagallery.Models;

namespace Instagallery.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<PhotoModel> Photos { get; set; }

        // Configure the model and seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial photo data
            modelBuilder.Entity<PhotoModel>().HasData(
                new PhotoModel
                {
                    Id = 1,
                    ThumbnailUrl = "/images/photo1_thumb.jpg",
                    Url = "/images/photo1.jpg",
                    Title = "Photo 1",
                    Description = "This is the description for Photo 1."
                },
                new PhotoModel
                {
                    Id = 2,
                    ThumbnailUrl = "/images/photo2_thumb.jpg",
                    Url = "/images/photo2.jpg",
                    Title = "Photo 2",
                    Description = "This is the description for Photo 2."
                }
            );
        }
    }
}
