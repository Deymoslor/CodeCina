﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Domain.Entities
{
    public class MenuProduct
    {
        public int IdMenuProducto { get; set; }
        public int? IdProducto { get; set; }
        public int? IdMenu { get; set; }
    }
}
