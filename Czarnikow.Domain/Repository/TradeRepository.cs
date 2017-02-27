using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Czarnikow.Domain.Entities;
using System.Data.Entity;


namespace Czarnikow.Domain.Repository
{
    public class TradeRepository : ITradeRepository, IDisposable
    {

        private TradeDbContext db;

        private IDbSet<Trade> entity;

        public TradeRepository()
        {
            this.db = new TradeDbContext();
            this.entity = this.db.Set<Trade>();
        }

        public Trade Get(int tradeId)
        {
            return this.entity.Find(tradeId);
        }

        public IQueryable<Trade> GetTrades()
        {
            return this.db.Trades.Include(x => x.Product).Include(y => y.Client);
        }

        public void Update(Trade trade)
        {
            this.entity.Attach(trade);
            this.db.Entry(trade).State = EntityState.Modified;
            this.db.SaveChanges();

        }

        public void Dispose()
        {
            this.db.Dispose();
        }

    }
}
