using Microsoft.EntityFrameworkCore;
using HonorOfEFCore.Models;

namespace HonorOfEFCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Factor> Factors { get; set; }
    public DbSet<FactorItem> FactorItems { get; set; }
}