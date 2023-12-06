using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Dtos.MenuProduct
{
    public class DishProductDto
    {

        public int IdDishProduct { get; set; }
        public int? IdProduct { get; set; }
        public int? IdDish { get; set; }



        public int? IdTipoProducto { get; set; }
        public int? IdMedida { get; set; }
        public string? NombreMenu { get; set; }
        public string? DescripcionMenu { get; set; }
        public string? NotaMenu { get; set; }
        public string? NombreProducto { get; set; }
        public int? CantidadProducto { get; set; }
        public string? NombreTipoProducto { get; set; }
        public string? DescipcionMedida { get; set; }
}
}
