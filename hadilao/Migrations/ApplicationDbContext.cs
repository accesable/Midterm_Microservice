using hadilao.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace E_Commerces.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    {
    }
    public DbSet<Order> Orders{get;set;}
    public DbSet<Dish> Dishes {get;set;}
    public DbSet<OrderDetail> OrderDetails {get;set;}
    public DbSet<Table> Tables {get;set;}
}