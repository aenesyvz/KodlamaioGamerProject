using KodlamaioWorkshop.Abstract;
using KodlamaioWorkshop.Concrete;
using KodlamaioWorkshop.Entities;
using System;

namespace KodlamaioGamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            GameManager gameManager = new GameManager();
            OrderManager orderManager = new OrderManager();
            CampaignManager campaignManager = new CampaignManager();

            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Alper Enes",
                LastName = "Yavuz",
                DateOfYear = new DateTime(2002, 2, 18),
                NationalityId = "12345678910"
            };
            gamerManager.Add(gamer1);
            Gamer gamer2 = new Gamer()
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Eskisemerci",
                DateOfYear = new DateTime(2001, 11, 27),
                NationalityId = "10987654321"
            };
            gamerManager.Add(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer1);
            
            Game game1 = new Game { Id = 1, GameName = "Counter Strike ", GamePrice = 200 };
            Game game2 = new Game { Id = 2, GameName = "GTA 5  ", GamePrice = 140 };

            gameManager.Add(game2);
            gameManager.Update(game1);

            
            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "  %60 İNDİRİMLİ ", Discount = 0.60M };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "  %80 İNDİRİMLİ ", Discount = 0.80M };
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            orderManager.Order(gamer1, game1);
            orderManager.OrderByCampaign(gamer1, game1, campaign1);
        }
    }
}
