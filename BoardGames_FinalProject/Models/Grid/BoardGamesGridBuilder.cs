using BoardGames_FinalProject.Models.DTOs;
using BoardGames_FinalProject.Models.ExtensionMethods;
using Microsoft.AspNetCore.Http;

namespace BoardGames_FinalProject.Models.Grid
{
    public class BoardGamesGridBuilder : GridBuilder
    {
        public BoardGamesGridBuilder(ISession sess) : base(sess) { }
        public BoardGamesGridBuilder(ISession sess, BoardGamesGridDTO values,
        string defaultSortField) : base(sess, values, defaultSortField)
        {
            
            routes.PriceFilter =  values.Price;
        }

        public void LoadFilterSegments(string[] filter)
        {
            routes.PriceFilter = FilterPrefix.Price + filter[2];
        }

        string def = BoardGamesGridDTO.DefaultFilter;   
        public bool IsFilterByPrice => routes.PriceFilter != def;

        public bool IsSortByPrice =>
            routes.SortField.EqualsNoCase(nameof(BoardGame.price));
    }
}
