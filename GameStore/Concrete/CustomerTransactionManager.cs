using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Abstract;
using GameStore.Entities;

namespace GameStore.Concrete
{
    public class CustomerTransactionManager:ICustomerTransactionService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted : " + customer.FirstName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Updated : " + customer.FirstName);
        }
    }
}
