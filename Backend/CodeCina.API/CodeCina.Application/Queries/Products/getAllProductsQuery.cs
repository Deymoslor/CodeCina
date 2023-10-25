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
    public class getAllProductsQuery: IRequest<List<productDto>>
    {

    }
    public class getAllProductsQueryHandler: IRequestHandler<getAllProductsQuery, List<productDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<getAllProductsQueryHandler> _logger;

        public getAllProductsQueryHandler(IApplicationDbContext context, ILogger<getAllProductsQueryHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<productDto>> Handle(getAllProductsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("getAllProductsQueryHandler Started");
            var query = await _context.Productos
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            var products = query.Select(x => new productDto
            {
                Nombre = x.Nombre,
                Cantidad = x.Cantidad,
                IdMedida = x.IdMedida,
                IdProducto = x.IdProducto,
                IdTipoProducto = x.IdTipoProducto,
            }
            ).ToList();

            _logger.LogDebug("getAllProductsQueryHandler Finished");
            return products;
        }
    }
}
