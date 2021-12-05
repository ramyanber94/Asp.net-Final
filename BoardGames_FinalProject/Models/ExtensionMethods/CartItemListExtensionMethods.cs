using BoardGames_FinalProject.Models;
using BoardGames_FinalProject.Models.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace BoardGames_FinalProject.Models.ExtensionMethods
{
    public static class CartItemListExtensions
    {
        public static List<CartItemDTO> ToDTO(this List<CartItem> list) =>
            list.Select(ci => new CartItemDTO
            {
                BoardGameId = ci.BoardGame.BoardGameId,
                Quantity = ci.Quantity
            }).ToList();
    }
}
