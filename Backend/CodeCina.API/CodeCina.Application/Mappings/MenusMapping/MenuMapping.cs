using AutoMapper;
using CodeCina.Application.Commands.TypeProducts;
using CodeCina.Application.Dtos.MenuDto;
using CodeCina.Application.Dtos.TypeProductsDto;
using CodeCina.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Mappings.MenusMapping
{

    public class MenuMapping : Profile
    {
        public MenuMapping()
        {
            CreateMap<Dish, DishDto>();
        }
    }
}
