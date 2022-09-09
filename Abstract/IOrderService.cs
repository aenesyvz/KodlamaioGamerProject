using KodlamaioWorkshop.Entities;

namespace KodlamaioWorkshop.Abstract
{
    public interface IOrderService
    {
        void Order(Gamer gamer, Game game);
        void OrderByCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
