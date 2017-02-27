using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Czarnikow.Api.Models
{
    public class TradeModel
    {
        public int TradeId { get; set; }

        public string ClientName { get; set; }

        public string Product { get; set; }

        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        public double Amount { get; set; }
    }

}