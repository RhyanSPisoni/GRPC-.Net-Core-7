using Microsoft.EntityFrameworkCore;
using GameServer.Models;

namespace GameServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
