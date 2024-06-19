using Microsoft.EntityFrameworkCore;

public class Database : DbContext
{
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Type> Types { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ./Database.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(brands => {
            brands.HasKey(b => b.CategoryId);
            brands.Property(b => b.Description).HasColumnType("TEXT");
            brands.HasMany(b => b.products).WithOne(t => t.Category);
        });

        modelBuilder.Entity<Type>(type => {
            type.HasKey(t => t.ProductId);
            type.Property(t =>t.Description).HasColumnType("TEXT");
            type.Property(t => t.Price).IsRequired(false);
        });
    }
}