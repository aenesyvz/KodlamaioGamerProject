using KodlamaioWorkshop.Abstract;
using KodlamaioWorkshop.Entities;
using System;

namespace KodlamaioWorkshop.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer))
            {
                Console.WriteLine("{0} {1} oyuncu eklendi!",gamer.FirstName,gamer.LastName);
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} {1} adli oyuncu silindi!",gamer.FirstName,gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer))
            {
                Console.WriteLine("{0} {1} adli oyuncunun bilgileri guncellendi!", gamer.FirstName, gamer.LastName);
            }
            else
            {
                Console.WriteLine("Oyuncunun bilgileri guncellenemedi!");
            }
        }
    }
}
