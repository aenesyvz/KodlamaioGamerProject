using KodlamaioWorkshop.Entities;

namespace KodlamaioWorkshop.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
