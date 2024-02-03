using ApiRabbitMq.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRabbitMq.Context;

public class AppDbContext : DbContext
{
    protected readonly IConfiguration Configuration;
    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<Product> Products{get;set;}
}
