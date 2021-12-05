using System;

namespace BoardGames_FinalProject.Models.DTOs
{
    public class BoardGameDTO
    {
        public string BoardGameId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public void Load(BoardGame boardGame)
        {
            BoardGameId = boardGame.ID;
            Name = boardGame.name;
            Price = Convert.ToDouble(boardGame.price);
        }
    }
}
