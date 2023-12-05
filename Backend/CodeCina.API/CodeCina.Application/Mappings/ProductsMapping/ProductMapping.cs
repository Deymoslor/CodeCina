using AutoMapper;
using CodeCina.Application.Commands.Products;
using CodeCina.Application.Dtos.Products;
using CodeCina.Application.Queries.Products;
using CodeCina.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Mappings.ProductsMapping
{
    public class ProductMapping: Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<GetByIdProductQuery, Product>();

            CreateMap<AddProductCommand, Product>();
            CreateMap<EditProductCommand, Product>();
        }
    }
}
