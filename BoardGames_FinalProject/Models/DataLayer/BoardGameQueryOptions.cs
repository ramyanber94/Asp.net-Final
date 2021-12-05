using BoardGames_FinalProject.Models.Grid;
using System;
using System.Linq;

namespace BoardGames_FinalProject.Models.DataLayer
{
    public class BoardGameQueryOptions : QueryOptions<BoardGame>
    {
        public void SortFilter(BoardGamesGridBuilder builder)
        {
          
            if (builder.IsFilterByPrice) {
                if (builder.CurrentRoute.PriceFilter == "under7")
                    Where = b => Int32.Parse(b.price) < 7;
                else if (builder.CurrentRoute.PriceFilter == "7to14")
                    Where = b => Int32.Parse(b.price) >= 7 && Int32.Parse(b.price) <= 14;
                else
                    Where = b => Int32.Parse(b.price) > 14;
            }
         

          
            if (builder.IsSortByPrice) {
                OrderBy = b => b.price;
            }
            else  {
                OrderBy = b => b.name;
            }
        }
    }
}
