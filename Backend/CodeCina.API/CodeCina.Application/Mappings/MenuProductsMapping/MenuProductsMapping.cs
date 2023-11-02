using AutoMapper;
using CodeCina.Application.Dtos.MenuProduct;
using CodeCina.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Mappings.MenuProductsMapping
{
    public class MenuProductsMapping : Profile
    {
        public MenuProductsMapping() 
        {
            CreateMap<MenuProduct, MenuProductDto>();
        }
        
    }
}

