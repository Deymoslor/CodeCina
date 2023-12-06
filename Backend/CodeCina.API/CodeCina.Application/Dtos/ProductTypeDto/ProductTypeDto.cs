using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Dtos.TypeProductsDto
{
    public class ProductTypeDto
    {
        public int IdTypeProduct { get; set; }
        public string? NameProductType { get; set; }
        public bool? ProductTypeState { get; set; }
    }
}
