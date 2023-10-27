using AutoMapper;
using CodeCina.Application.Dtos.Products;
using CodeCina.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Queries.Products
{
    public class getAllProductsQuery: IRequest<List<ProductDto>>
    {

    }
    public class getAllProductsQueryHandler: IRequestHandler<getAllProductsQuery, List<ProductDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<getAllProductsQueryHandler> _logger;
        private readonly IMapper _mapper;

        public getAllProductsQueryHandler(IApplicationDbContext context, ILogger<getAllProductsQueryHandler> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> Handle(getAllProductsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("getAllProductsQueryHandler Started");
            var query = await _context.Productos
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            //var products = query.Select(x => new ProductDto
            //{
            //    Nombre = x.Nombre,
            //    Cantidad = x.Cantidad,
            //    IdMedida = x.IdMedida,
            //    IdProducto = x.IdProducto,
            //    IdTipoProducto = x.IdTipoProducto,
            //}
            //).ToList();

            var productsDto = _mapper.Map<List<ProductDto>>(query);


            _logger.LogDebug("getAllProductsQueryHandler Finished");
            return productsDto;
        }
    }
}
