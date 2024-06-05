using Microsoft.EntityFrameworkCore;
using WinFormsApp2;

namespace WinFormsApp2;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Hansabuss" },
            new Category { CategoryId = 2, Name = "LuxExpress" },
            new Category { CategoryId = 3, Name = "Taisto" },
            new Category { CategoryId = 4, Name = "Air" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Tallinn" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Tartu" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Pärnu" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Narva" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Viljandi" },
            new Product { ProductId = 6, CategoryId = 1, Name = "Rakvere" },
            new Product { ProductId = 7, CategoryId = 1, Name = "Haapsalu" },
            new Product { ProductId = 8, CategoryId = 1, Name = "Kuressaare" },
            new Product { ProductId = 9, CategoryId = 1, Name = "Võru" },
            new Product { ProductId = 10, CategoryId = 1, Name = "Valga" },
            new Product { ProductId = 11, CategoryId = 2, Name = "Tallinn" },
            new Product { ProductId = 12, CategoryId = 2, Name = "Tartu" },
            new Product { ProductId = 13, CategoryId = 2, Name = "Pärnu" },
            new Product { ProductId = 14, CategoryId = 2, Name = "Narva" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Viljandi" },
            new Product { ProductId = 16, CategoryId = 2, Name = "Rakvere" },
            new Product { ProductId = 17, CategoryId = 3, Name = "Haapsalu" },
            new Product { ProductId = 18, CategoryId = 3, Name = "Kuressaare" },
            new Product { ProductId = 19, CategoryId = 3, Name = "Võru" },
            new Product { ProductId = 20, CategoryId = 3, Name = "Valga" },
            new Product { ProductId = 21, CategoryId = 3, Name = "Tallinn" },
            new Product { ProductId = 22, CategoryId = 3, Name = "Tartu" },
            new Product { ProductId = 23, CategoryId = 3, Name = "Pärnu" },
            new Product { ProductId = 24, CategoryId = 4, Name = "Narva" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Viljandi" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Rakvere" });

    }
}