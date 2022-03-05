using System;
using GameStore.Abstract;
using GameStore.Adapters;
using GameStore.Concrete;
using GameStore.Entities;

namespace GameStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1996, 01, 13), FirstName = "MUZAFFER", LastName = "ŞENKAL", NationalityId = 1955568965 });

            GameSaleManager gameSale = new GameSaleManager();
            gameSale.Sales(new Game { GameName = "GTA5" },new Customer{ DateOfBirth = new DateTime(1996, 01, 13), FirstName = "MUZAFFER", LastName = "ŞENKAL", NationalityId = 1955568965 });

            CustomerTransactionManager customerTransactionManager = new CustomerTransactionManager();
            customerTransactionManager.Delete(new Customer { DateOfBirth = new DateTime(1996, 01, 13), FirstName = "MUZAFFER", LastName = "ŞENKAL", NationalityId = 1955568965 });



        }
    }
}
