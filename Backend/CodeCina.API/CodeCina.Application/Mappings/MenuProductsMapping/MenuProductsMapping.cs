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
            CreateMap<Product, DishProductDto>()
                .ForMember(x => x.NombreProducto, z => z.MapFrom(y => y.ProductName))
                .ForMember(x => x.CantidadProducto, z => z.MapFrom(y => y.Quantity));
            CreateMap<Dish, DishProductDto>()
                .ForMember(x => x.NombreMenu, z => z.MapFrom(y => y.DishName))
                .ForMember(x => x.DescripcionMenu, z => z.MapFrom(y => y.DishDescription))
                .ForMember(x => x.NotaMenu, z => z.MapFrom(y => y.DishNote));
            CreateMap<Measure, DishProductDto>()
                .ForMember(x => x.DescripcionMenu, z => z.MapFrom(y => y.DescriptionMeasure));
            CreateMap<ProductType, DishProductDto>()
                .ForMember(x => x.NombreTipoProducto, z => z.MapFrom(y => y.NameProductType));
        }
        
    }
}

