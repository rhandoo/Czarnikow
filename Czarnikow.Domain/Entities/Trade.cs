using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Czarnikow.Domain.Entities
{
    public class Trade
    {
        [Key]
        public int TradeId { get; set; }


        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int ClientId{ get; set; }
        public virtual Client Client { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public int Qty { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
