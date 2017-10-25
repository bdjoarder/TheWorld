using Microsoft.EntityFrameworkCore;
using TheWorld.Models;

namespace TheWorld.Data
{
    public class WorldContext : DbContext
    {
        public WorldContext()
        {

        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Stop> Stops { get; set; }
    }
}
