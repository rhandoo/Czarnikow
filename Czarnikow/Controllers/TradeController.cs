using Czarnikow.Api.Mappers;
using Czarnikow.Domain.Repository;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ninject;
using Czarnikow.Api.Models;

namespace Czarnikow.Api.Controllers
{
    public class TradeController : ApiController
    {
        private readonly ITradeRepository tradeRepository;

        private readonly ITradeMapper tradeMapper;

        public TradeController() : this(
                    Ioc.Kernel.Get<ITradeRepository>(), Ioc.Kernel.Get<ITradeMapper>())
        { }

        public TradeController(ITradeRepository tradeRepository, ITradeMapper tradeMapper)
        {
            this.tradeRepository = tradeRepository;

            this.tradeMapper = tradeMapper;

        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return this.ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, this.tradeMapper.Map(this.tradeRepository.GetTrades())));
        }

        [Route("trade/{tradeId}")]
        [HttpGet]
        public IHttpActionResult GetTrade(int tradeId)
        {
            var trade = this.tradeMapper.Map(this.tradeRepository.Get(tradeId));
            return Ok(trade);
        }
        
        [HttpPut]
        public IHttpActionResult Put(TradeModel model)
        {
            var trade = this.tradeRepository.Get(model.TradeId);
            trade.ModifiedBy = "Roger";
            trade.ModifiedDate = DateTime.Now;
            trade.Amount = model.Amount;
            trade.Qty = model.Quantity;
            this.tradeRepository.Update(trade);
            return Ok();
        }
    }
}
