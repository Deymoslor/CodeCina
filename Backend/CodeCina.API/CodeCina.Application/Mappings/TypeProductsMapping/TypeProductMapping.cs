using AutoMapper;
using CodeCina.Application.Commands.TypeProducts;
using CodeCina.Application.Dtos.TypeProductsDto;
using CodeCina.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Mappings.TypeProductsMapping
{
    public class TypeProductMapping : Profile
    {
        public TypeProductMapping()
        {
            CreateMap<TypeProduct, TypeProductDto>();

            CreateMap<AddTypeProductCommand, TypeProductDto>();
            CreateMap<AddTypeProductCommand, TypeProduct>();
        }
    }
}
