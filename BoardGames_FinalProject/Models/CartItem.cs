using BoardGames_FinalProject.Models.DTOs;
using System.Text.Json.Serialization;

namespace BoardGames_FinalProject.Models
{
    public class CartItem
    {
        public BoardGameDTO BoardGame { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public double Subtotal => BoardGame.PriceCa * Quantity;
    }
}
