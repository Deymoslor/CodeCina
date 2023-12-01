using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Domain.Entities
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
        public bool? ProductState { get; set; }
        public int? IdTypeProduct { get; set; }
        public int? IdMeasure { get; set; }
    }
}
