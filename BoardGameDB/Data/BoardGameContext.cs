using Microsoft.EntityFrameworkCore;
using BoardGameDB.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BoardGameDB.Data
{
    public class BoardGameContext : IdentityDbContext<User>
    {
        public BoardGameContext(DbContextOptions<BoardGameContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Game> Game { get; set; }
    }
}