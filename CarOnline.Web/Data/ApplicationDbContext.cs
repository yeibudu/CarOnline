using CarOnline.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CarOnline.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        } 

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Brand> Brands { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vehicle>()
                .HasIndex(t => t.Plate)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasIndex(t => t.Document)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>()
                .HasIndex(t => t.Name)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photo>()
                .HasIndex(t => t.Name)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brand>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
