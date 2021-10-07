using Domain.Aggregate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ShopList> ShopLists;
        public DbSet<Product> Products;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShopList>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasColumnType("varchar(200)")
                .HasMaxLength(50).IsRequired();
                entity.Property(e => e.Owner).HasColumnType("varchar(200)")
                .HasMaxLength(50).IsRequired();
                entity.Property(e => e.IdealValue).HasColumnType("DECIMAL(10,2)");
                entity.Property(e => e.MaxValue).HasColumnType("DECIMAL(10,2)").IsRequired();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasColumnType("varchar(200)")
                .HasMaxLength(50).IsRequired();
                entity.Property(e => e.Price).HasColumnType("DECIMAL(10,2)").IsRequired();
                entity.Property(e => e.Quantity).HasColumnType("int").IsRequired();
                entity.Property(e => e.IsChecked).IsRequired();

                entity.HasOne(d => d.ShopList)
                  .WithMany(p => p.Products);
            });
        }
    }
}
