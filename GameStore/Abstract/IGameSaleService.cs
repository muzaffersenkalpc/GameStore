using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Entities;

namespace GameStore.Abstract
{
    public interface IGameSaleService
    {
        
        void Sales(Game game, Customer customer);
    }
}
