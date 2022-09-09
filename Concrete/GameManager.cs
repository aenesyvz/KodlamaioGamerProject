using KodlamaioWorkshop.Abstract;
using KodlamaioWorkshop.Entities;
using System;
namespace KodlamaioWorkshop.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} adli oyun sisteme eklendi!", game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} adli oyun sistemden silindi!",game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} adli oyunun bilgileri guncellendi!",game.GameName);
        }
    }

        
}