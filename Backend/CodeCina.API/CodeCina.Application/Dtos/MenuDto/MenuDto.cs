﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Dtos.MenuDto
{
    public class MenuDto
    {
        public int IdMenu { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Nota { get; set; }
    }
}
