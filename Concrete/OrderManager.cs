using KodlamaioWorkshop.Abstract;
using KodlamaioWorkshop.Entities;
using System;
namespace KodlamaioWorkshop.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Order(Gamer gamer, Game game)
        {
            Console.WriteLine("{0} {1} adli oyuncu {2} oyunu {3} TL 'ye satin aldi!",gamer.FirstName,gamer.LastName,game.GameName,game.GamePrice);
        }

        public void OrderByCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("{0} {1} adli oyuncu {2} oyunu {3} kampanyasiyla {4} TL 'ye satin aldi!", gamer.FirstName, gamer.LastName, game.GameName,campaign.CampaignName ,game.GamePrice*campaign.Discount);
        }
    }
}
