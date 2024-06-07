using Microsoft.EntityFrameworkCore;

namespace EntityFramework;
class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlite("Data Source=Northwind.db");

        // must install package:
        //Npgsql.EntityFrameworkCore.PostgreSql
        //PostgreSql
        //optionsBuilder.Npgsql("Host=localhost;Port=5432;Database=myDB;Username=postgre;Password=postgre")
    }
}