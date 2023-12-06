using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Domain.Entities
{
    public class Dish
    {
        public int IdDish { get; set; }
        public string DishName { get; set; } = null!;
        public string? DishDescription { get; set; }
        public string? DishNote { get; set; }
        public double? Price { get; set; }
        public bool? DishState { get; set; }
        public string? DishImageUrl { get; set; }
    }
}
