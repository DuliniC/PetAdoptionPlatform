using Microsoft.EntityFrameworkCore;
using webapi.Models.Entities;

namespace webapi.Models
{
    public class FFriendFinderDbContext : DbContext
    {
        public FFriendFinderDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AdoptionApplication> AdoptionApplications { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserEventTable> UserEvents { get; set; }
    }
}
