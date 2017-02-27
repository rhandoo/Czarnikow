using Czarnikow.Api.Models;
using Czarnikow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czarnikow.Api.Mappers
{
    public interface ITradeMapper
    {
        IEnumerable<TradeModel> Map(IQueryable<Trade> trades);

        TradeModel Map(Trade trade);

    }
}
