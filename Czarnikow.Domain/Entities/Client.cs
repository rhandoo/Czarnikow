using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Czarnikow.Domain.Entities
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
