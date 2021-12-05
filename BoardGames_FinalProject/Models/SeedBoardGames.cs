using BoardGames_FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BoardGames_FinalProject.Models
{
    public class SeedBoardGames : IEntityTypeConfiguration<BoardGame>
    {
        public void Configure(EntityTypeBuilder<BoardGame> builder)
        {
            foreach (var item in Service.GetBoardGames().games)
            {

                builder.HasData(
                    new BoardGame
                    {
                        ID = item.ID,
                        name = item.name,
                        min_age = item.min_age,
                        min_players = item.min_players,
                        max_players = item.max_players,
                        price = item.price,
                        price_ca = item.price_ca,
                        description = item.description,
                        image_url = item.image_url
                    }
                    );

            }
        }
    }
}
