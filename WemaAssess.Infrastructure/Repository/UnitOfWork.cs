using System;
using System.Collections.Generic;
using System.Text;
using WemaAssess.Infrastructure.Data;

namespace WemaAssess.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _context;
        public IRepository<Customer> Customer { private set; get; }
        public IRepository<State> State { private set; get; }
        public IRepository<Lga> Lga { private set; get; }

        public UnitOfWork(DataContext context)
        {
            _context = context;

            Customer = new Repository<Customer>(_context);
            State = new Repository<State>(_context);
            Lga = new Repository<Lga>(_context);
        }
    }
}
