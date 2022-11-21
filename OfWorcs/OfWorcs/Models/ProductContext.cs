using System;
using Microsoft.EntityFrameworkCore;

namespace OfWorcs.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=Unitofworcs;Integrated Security=True;");
        }
    }
}
