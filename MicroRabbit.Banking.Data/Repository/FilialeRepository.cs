using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace MicroRabbit.Banking.Data.Repository
{
   public  class FilialeRepository : IFilialeIRepository
    {
        private BankingDbContext _ctx;

        public FilialeRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Filiale> GetFiliales()
        {
            return _ctx.filiales;
        }
    }
}
