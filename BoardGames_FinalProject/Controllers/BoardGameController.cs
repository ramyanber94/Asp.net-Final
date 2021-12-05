using BoardGames_FinalProject.Models;
using BoardGames_FinalProject.Models.DataLayer;
using BoardGames_FinalProject.Models.DTOs;
using BoardGames_FinalProject.Models.Grid;
using BoardGames_FinalProject.Models.ViewModels;
using BoardGames_FinalProject.Services;
using BoardGamestore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceStack.Text;
using System;
using System.Threading.Tasks;

namespace BoardGames_FinalProject.Controllers
{
    public class BoardGameController : Controller
    {
        private readonly BoardGameContext _context;
        public BoardGameController(BoardGameContext context)
        {
            _context = context;
            data = new BoardGamestoreUnitOfWork(context);
        }
        private BoardGamestoreUnitOfWork data;
        public async Task<IActionResult> Details(string id)
        {
            var boardGame = await _context.BoardGames
                .FirstOrDefaultAsync(m => m.ID == id);

            return View(boardGame);
        }

        public async Task<IActionResult> ListAsync(BoardGamesGridDTO values)
        {

            var builder = new BoardGamesGridBuilder(HttpContext.Session, values,
            defaultSortField: nameof(BoardGame.name));

            var options = new BoardGameQueryOptions
            {

                OrderByDirection = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
            };
            options.SortFilter(builder);

            var vm = new BoardGameListViewModel
            {
                BoardGames = data.BoardGames.List(options),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.BoardGames.Count)
            };

            return View(vm);
        }
    }
}
