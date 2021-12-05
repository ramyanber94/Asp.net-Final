using BoardGames_FinalProject.Models;
using BoardGames_FinalProject.Models.Grid;
using System.Collections.Generic;

namespace BoardGames_FinalProject.Models

{
    public class CartViewModel 
    {
        public IEnumerable<CartItem> List { get; set; }
        public double Subtotal { get; set; }

        public RouteDictionary BoardGameGridRoute { get; set; }
    }
}
