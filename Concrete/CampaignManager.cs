using KodlamaioWorkshop.Abstract;
using KodlamaioWorkshop.Entities;
using System;
namespace KodlamaioWorkshop.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} adli kampanya sisteme eklendi!",campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} adli kampanya sistemden silindi!",campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} adli kampanyanin bilgileri guncellendi!",campaign.CampaignName);
        }
    }
}
