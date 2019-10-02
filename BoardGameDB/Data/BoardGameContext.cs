using Microsoft.EntityFrameworkCore;
using BoardGameDB.Models;

namespace BoardGameDB.Data
{
    public class BoardGameContext : DbContext
    {
        public BoardGameContext(DbContextOptions<BoardGameContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Game { get; set; }
    }
}