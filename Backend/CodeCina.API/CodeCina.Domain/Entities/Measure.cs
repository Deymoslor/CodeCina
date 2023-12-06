using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Domain.Entities
{
    public class Measure
    {
        public int IdMeasure { get; set; }
        public string Abbreviation { get; set; } = null!;
        public string? DescriptionMeasure { get; set; }
        public bool? MeasureState { get; set; }
    }
}
