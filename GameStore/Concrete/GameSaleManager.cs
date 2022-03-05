using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Abstract;
using GameStore.Entities;

namespace GameStore.Concrete
{
    class GameSaleManager:IGameSaleService
    {
        
        public void Sales(Game game,Customer customer)
        {
            
                Console.WriteLine("Success ," + customer.FirstName + " you have : "  + game.GameName +  "Have fun!");
            
        }

    }
}
