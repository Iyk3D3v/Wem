using System;
using System.Collections.Generic;
using System.Text;
using WemaAssess.Infrastructure.Data;

namespace WemaAssess.Infrastructure.Repository
{
    public interface IUnitOfWork
    {
        IRepository<Customer> Customer {get;}
        IRepository<State> State {get;}
        IRepository<Lga> Lga {get;}
    }
}
