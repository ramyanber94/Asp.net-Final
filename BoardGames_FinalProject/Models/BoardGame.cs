using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardGames_FinalProject.Models
{
    public class Games
    {
        public List<BoardGame> games { get; set; }
    }
    public class BoardGame
    {
        [Key]
        public string ID { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter minimum number of players.")]
        [Range(1, 999, ErrorMessage = "Number of players must be bigger than zero.")]
        public string min_players { get; set; }
        [Required(ErrorMessage = "Please enter maximum number of players.")]
        [Range(1, 999, ErrorMessage = "Number of players must be bigger than zero.")]
        public string max_players { get; set; }

        [Range(0, 99, ErrorMessage = "Age must be between {1} and {2}.")]
        public string min_age { get; set; }
        [Required(ErrorMessage = "Please enter a price.")]
        public string price { get; set; }
        [Required(ErrorMessage = "Please enter a price.")]
        public string price_ca { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }


    }
}
