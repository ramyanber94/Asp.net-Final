using BoardGames_FinalProject.Models;
using BoardGames_FinalProject.Models.DataLayer;
using BoardGames_FinalProject.Models.DataLayer.Repositories;
using System.Linq;

namespace BoardGamestore.Models
{
    public class BoardGamestoreUnitOfWork : IBoardGamestoreUnitOfWork
    {
        private BoardGameContext context { get; set; }
        public BoardGamestoreUnitOfWork(BoardGameContext ctx) => context = ctx;

        private Repository<BoardGame> boardGameData;
        public Repository<BoardGame> BoardGames {
            get {
                if (boardGameData == null)
                    boardGameData = new Repository<BoardGame>(context);
                return boardGameData;
            }
        }

        public void Save() => context.SaveChanges();
    }
}