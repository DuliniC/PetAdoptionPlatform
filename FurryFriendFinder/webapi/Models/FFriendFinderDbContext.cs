using Microsoft.EntityFrameworkCore;

namespace webapi.Models
{
    public class FFriendFinderDbContext : DbContext
    {
        public FFriendFinderDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
