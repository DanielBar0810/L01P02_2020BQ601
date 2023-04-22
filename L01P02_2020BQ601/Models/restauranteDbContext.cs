using Microsoft.EntityFrameworkCore;
using L01P02_2020BQ601.Models;
namespace L01P02_2020BQ601.Models

{
    public class restauranteDbContext : DbContext
    {

        public restauranteDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<pedidos> pedidos { get; set; }

        public DbSet<platos> platos { get; set; }

        public DbSet<motoristas> motoristas { get; set; }

        public DbSet<clientes> clientes { get; set; }



    }
}

