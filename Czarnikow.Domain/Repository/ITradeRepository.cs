using Czarnikow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czarnikow.Domain.Repository
{
    public interface ITradeRepository
    {
        IQueryable<Trade> GetTrades();
        Trade Get(int tradeId);
        void Update(Trade trade);

    }
}
