using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardGameDB.Models
{
    public class Game
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String ImageURL { get; set; }

        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }

        [Display(Name ="Added By")]
        public string AddedByUser { get; set; }

        [Display(Name ="Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

    }
}
