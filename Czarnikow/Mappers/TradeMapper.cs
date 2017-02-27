using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Czarnikow.Api.Models;
using Czarnikow.Domain.Entities;

namespace Czarnikow.Api.Mappers
{
    public class TradeMapper : ITradeMapper
    {
        public IEnumerable<TradeModel> Map(IQueryable<Trade> trades)
        {
            var tradeModels = new List<TradeModel>();
            foreach (var trade in trades)
            {
                tradeModels.Add(this.Map(trade));

            }
            return tradeModels;
        }


        public TradeModel Map(Trade trade)
        {
            return new TradeModel { TradeId = trade.TradeId, Amount = trade.Amount, ClientName = trade.Client.Name, Product = trade.Product.Description, Quantity = trade.Qty, Date = trade.Date };
        }
    }
}