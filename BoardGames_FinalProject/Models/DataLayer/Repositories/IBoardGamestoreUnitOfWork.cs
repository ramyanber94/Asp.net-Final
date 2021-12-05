using BoardGames_FinalProject.Models;
using BoardGames_FinalProject.Models.DataLayer.Repositories;

namespace BoardGamestore.Models
{
    public interface IBoardGamestoreUnitOfWork
    {
        Repository<BoardGame> BoardGames { get; }

        void Save();
    }
}
