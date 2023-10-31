using AutoMapper;
using CodeCina.Application.Dtos.Products;
using CodeCina.Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Queries.Products
{
    public class GetByIdProductQuery: IRequest<ProductDto>
    {
        public int IdProducto { get; set; }
    }
    public class GetByIdProductQueryHandler: IRequestHandler<GetByIdProductQuery, ProductDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<GetByIdProductQueryHandler> _logger;
        private readonly IMapper _mapper;

        public GetByIdProductQueryHandler(IApplicationDbContext context, 
            IMapper mapper, 
            ILogger<GetByIdProductQueryHandler> logger) 
        { 
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProductDto> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("GetByIdProductQuery Started");
            var query = await _context.Products
                .FirstOrDefaultAsync(x => x.IdProducto == request.IdProducto, cancellationToken);

            var productDto = _mapper.Map<ProductDto>(query);

            _logger.LogDebug("GetByIdProductQuery Finished");
            return productDto;

        }
    }
}
