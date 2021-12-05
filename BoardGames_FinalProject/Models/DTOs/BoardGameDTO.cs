using System;

namespace BoardGames_FinalProject.Models.DTOs
{
    public class BoardGameDTO
    {
        public string BoardGameId { get; set; }
        public string Name { get; set; }
        public double PriceCa { get; set; }

        public void Load(BoardGame boardGame)
        {
            BoardGameId = boardGame.ID;
            Name = boardGame.name;
            PriceCa = Convert.ToDouble(boardGame.price_ca);
        }
    }
}
