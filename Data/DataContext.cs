using Dotnet_rpg3.Models;
using Dotnet_rpg3.Models.Track;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_rpg3.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<MeetResult> MeetResults { get; set; }
        public DbSet<PracticeResult> PracticeResults { get; set; }
        public DbSet<User> Users { get; set; }
    }
}