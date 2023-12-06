using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Domain.Entities
{
    public class ProductType
    {
        public int IdTypeProduct { get; set; }
        public string? NameProductType { get; set; }
        public bool? ProductTypeState { get; set; }
    }
}
