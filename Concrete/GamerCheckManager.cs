using KodlamaioWorkshop.Abstract;
using KodlamaioWorkshop.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KodlamaioWorkshop.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            return true;
        }
    }
}
