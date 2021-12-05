using BoardGames_FinalProject.Models;
using BoardGames_FinalProject.Models.DataLayer;
using BoardGames_FinalProject.Models.DataLayer.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BoardGames_FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private Repository<BoardGame> data { get; set; }
        public HomeController(BoardGameContext ctx) => data = new Repository<BoardGame>(ctx);

        public ViewResult Index()
        {
            var random = data.Get(new QueryOptions<BoardGame>
            {
                OrderBy = b => Guid.NewGuid()
            });

            return View(random);
        }
    }
}
