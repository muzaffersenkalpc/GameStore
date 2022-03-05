﻿using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public  virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved : " + customer.FirstName);
        }
    }
}
