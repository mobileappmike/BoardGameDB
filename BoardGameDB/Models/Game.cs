using System;
namespace BoardGameDB.Models
{
    public class Game
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String ImageName { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
