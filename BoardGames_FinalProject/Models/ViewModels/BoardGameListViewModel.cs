using BoardGames_FinalProject.Models.Grid;
using BoardGames_FinalProject.Services;
using System.Collections.Generic;

namespace BoardGames_FinalProject.Models.ViewModels
{
    public class BoardGameListViewModel 
    {
        public IEnumerable<BoardGame> BoardGames { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        
        public int TotalPages { get; set; }
        public Dictionary<string, string> Prices =>
           new Dictionary<string, string> {
                { "under7", "Under $7" },
                { "7to14", "$7 to $14" },
                { "over14", "Over $14" }
           };
    }
}
