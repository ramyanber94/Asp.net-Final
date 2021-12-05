using BoardGames_FinalProject.Models.Grid;
using BoardGames_FinalProject.Services;
using System.Collections.Generic;

namespace BoardGames_FinalProject.Models.ViewModels
{
    public class BoardGameListViewModel 
    {
   
        public RouteDictionary CurrentRoute { get; set; }
        public IEnumerable<BoardGame> BoardGames { get; set; }
        
        public int TotalPages { get; set; }
    }
}
