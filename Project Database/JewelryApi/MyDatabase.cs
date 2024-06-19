using Microsoft.EntityFrameworkCore;

public class MyDatabase : DbContext
{
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Type> Types { get; set; }
    public DbSet<Factory> Factories { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(brands => {
            brands.HasKey(b => b.BrandId);
            brands.Property(b => b.Description).HasColumnType("TEXT");
            brands.HasMany(b => b.Types).WithOne(t => t.Brand);
        });

        modelBuilder.Entity<Type>(type => {
            type.HasKey(t => t.TypeId);
            type.Property(t =>t.Description).HasColumnType("TEXT");
            type.Property(t => t.Price).IsRequired(false);
        });

        modelBuilder.Entity<Factory>(factories => {
            factories.HasKey(t => t.FactoryId);
            factories.Property(t =>t.FactoryName).HasColumnType("TEXT");
            factories.Property(t => t.ProductionPrice).IsRequired(false);
        });
    }
}