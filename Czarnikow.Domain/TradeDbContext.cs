using Czarnikow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czarnikow.Domain
{

    public sealed class TradeDbContext : DbContext
    {
        public TradeDbContext() : base("TradeDbContext")
        {
        }


        public IDbSet<Product> Products { get; set; }

        public IDbSet<Client> Clients { get; set; }

        public IDbSet<Trade> Trades { get; set; }


    }
}

