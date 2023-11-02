using AutoMapper;
using CodeCina.Application.Dtos.MenuProduct;
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

namespace CodeCina.Application.Queries.MenuProducts
{
    public class GetAllMenuProductsQuery : IRequest<List<MenuProductDto>>
    {
    } 

    public class GetAllMenuProductsQueryHandler : IRequestHandler<GetAllMenuProductsQuery, List<MenuProductDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<GetAllMenuProductsQueryHandler> _logger;
        private readonly IMapper _mapper;

        public GetAllMenuProductsQueryHandler(IApplicationDbContext context, IMapper mapper, ILogger<GetAllMenuProductsQueryHandler> logger) 
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<MenuProductDto>> Handle(GetAllMenuProductsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("GetAllMenuProductsQueryHandler STARTED");
            var query = await _context.MenuProducts
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            var productsDto = _mapper.Map<List<MenuProductDto>>(query);

            _logger.LogDebug("GetAllMenuProductsQueryHandler FINISHED");

            return productsDto;

        }
    }

}
