using BoardGames_FinalProject.Models;
using BoardGames_FinalProject.Models.DataLayer;
using BoardGames_FinalProject.Models.DataLayer.Repositories;
using BoardGames_FinalProject.Models.DTOs;
using BoardGames_FinalProject.Models.Grid;
using BoardGames_FinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BoardGames_FinalProject.Controllers
{
    public class CartController : Controller
    {
        private Repository<BoardGame> data { get; set; }
        public CartController(BoardGameContext ctx) => data = new Repository<BoardGame>(ctx);


        private Cart GetCart()
        {
            var cart = new Cart(HttpContext);
            cart.Load(data);
            return cart;
        }

        public ViewResult Index()
        {
            var cart = GetCart();

            var vm = new CartViewModel
            {
                List = cart.List,
                Subtotal = cart.Subtotal
            };
            return View(vm);
        }

        [HttpPost]
        public RedirectToActionResult Add(string id)
        {
            var boardGame = data.Get(new QueryOptions<BoardGame>
            {
                Where = b => b.ID == id
            });
            if (boardGame == null)
            {
                TempData["message"] = "Unable to add BoardGame to cart.";
            }
            else
            {
                var dto = new BoardGameDTO();
                dto.Load(boardGame);
                CartItem item = new CartItem
                {
                    BoardGame = dto,
                    Quantity = 1  // default value
                };

                Cart cart = GetCart();
                cart.Add(item);
                cart.Save();

                TempData["message"] = $"{boardGame.name} added to cart";
            }
            var builder = new BoardGamesGridBuilder(HttpContext.Session);
            return RedirectToAction("List", "BoardGame", builder.CurrentRoute);
        }

        [HttpPost]
        public RedirectToActionResult Remove(string id)
        {
            Cart cart = GetCart();
            CartItem item = cart.GetById(id);
            cart.Remove(item);
            cart.Save();

            TempData["message"] = $"{item.BoardGame.Name} removed from cart.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult Clear()
        {
            Cart cart = GetCart();
            cart.Clear();
            cart.Save();

            TempData["message"] = "Cart cleared.";
            return RedirectToAction("Index");
        }


        public IActionResult Edit(string id)
        {
            Cart cart = GetCart();
            CartItem item = cart.GetById(id);
            if (item == null)
            {
                TempData["message"] = "Unable to locate cart item";
                return RedirectToAction("Index");
            }
            else
            {
                return View(item);
            }
        }

        [HttpPost]
        public RedirectToActionResult Edit(CartItem item)
        {
            Cart cart = GetCart();
            cart.Edit(item);
            cart.Save();

            TempData["message"] = $"{item.BoardGame.Name} updated";
            return RedirectToAction("Index");
        }

        public ViewResult Checkout() => View();
    }
}
