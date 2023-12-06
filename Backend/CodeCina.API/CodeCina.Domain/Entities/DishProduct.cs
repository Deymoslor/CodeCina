using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Domain.Entities
{
    public class DishProduct
    {
        public int IdDishProduct { get; set; }
        public int? IdProduct { get; set; }
        public int? IdDish { get; set; }
    }
}
