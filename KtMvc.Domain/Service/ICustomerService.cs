﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Models;
using KtMvc.Domain.Repository;

namespace KtMvc.Domain.Service
{
    public interface ICustomerService : IService<Customer, ICustomerRepository>
    {
        IEnumerable<Customer> GetCustomers(string name);
    }
}
