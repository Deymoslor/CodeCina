using AutoMapper;
using CodeCina.Application.Dtos.TypeProductsDto;
using CodeCina.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Queries.TypeProducts
{
    public class getAllTypeProductsQuery : IRequest<List<ProductTypeDto>>
    {

    }

    public class getAllTypeProductsQueryHandler : IRequestHandler<getAllTypeProductsQuery, List<ProductTypeDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<getAllTypeProductsQueryHandler> _logger;
        private readonly IMapper _mapper;

        public getAllTypeProductsQueryHandler(IApplicationDbContext context, ILogger<getAllTypeProductsQueryHandler> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<ProductTypeDto>> Handle(getAllTypeProductsQuery query, CancellationToken cancellationToken)
        {
            _logger.LogDebug("");

            var consulta = await _context.ProductTypes.ToListAsync();

            var result = _mapper.Map<List<ProductTypeDto>>(consulta);

            _logger.LogDebug("");

            return result;
        }


    }
}
