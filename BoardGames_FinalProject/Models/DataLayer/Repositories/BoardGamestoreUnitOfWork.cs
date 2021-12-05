using BoardGames_FinalProject.Models;
using BoardGames_FinalProject.Models.DataLayer;
using BoardGames_FinalProject.Models.DataLayer.Repositories;
using System.Linq;

namespace BoardGamestore.Models
{
    public class BoardGamestoreUnitOfWork : IBoardGamestoreUnitOfWork
    {
        private BoardGameContext Context { get; set; }
        public BoardGamestoreUnitOfWork(BoardGameContext ctx) => Context = ctx;

        private Repository<BoardGame> boardGameData;
        public Repository<BoardGame> BoardGames {
            get {
                if (boardGameData == null)
                    boardGameData = new Repository<BoardGame>(Context);
                return boardGameData;
            }
        }

        public void Save() => Context.SaveChanges();
    }
}