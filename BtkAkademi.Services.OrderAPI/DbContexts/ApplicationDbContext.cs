using BtkAkademi.Services.OrderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademi.Services.OrderAPI.DbContexts
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
