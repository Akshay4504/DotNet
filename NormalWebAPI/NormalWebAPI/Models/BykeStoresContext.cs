using Microsoft.EntityFrameworkCore;

namespace DockerWebAPI.Models
{
    public class BykeStoresContext : DbContext
    {
        public BykeStoresContext(DbContextOptions<BykeStoresContext> options) : base(options) { }

        public virtual DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-6B6KT5K;Database=ProductDB;Integrated Security=true;Trusted Connection=true");
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.brandId).HasName("primary_key");

                entity.ToTable("brands", "production");
                entity.Property(e => e.brandId).HasColumnName("brand_id");
                entity.Property(e => e.brandName)
                    .HasColumnName("brand_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
