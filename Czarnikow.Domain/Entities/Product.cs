
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;

    namespace Czarnikow.Domain.Entities
    {
        public class Product
        {
            [Key]
            public int ProductId { get; set; }

            [Required]
            public string Description { get; set; }
        }
    }


