using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Dtos.Products
{
    public class productDto
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public int? IdTipoProducto { get; set; }
        public int? Cantidad { get; set; }
        public int? IdMedida { get; set; }
    }
}
