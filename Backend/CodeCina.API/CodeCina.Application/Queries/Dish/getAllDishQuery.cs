using AutoMapper;
using CodeCina.Application.Dtos.MenuDto;
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

namespace CodeCina.Application.Queries.Menu
{

    public class getAllDishQuery : IRequest<List<DishDto>>
    {

    }

    public class getAllMenuQueryHandler : IRequestHandler<getAllDishQuery, List<DishDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<getAllMenuQueryHandler> _logger;
        private readonly IMapper _mapper;

        public getAllMenuQueryHandler(IApplicationDbContext context, ILogger<getAllMenuQueryHandler> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<DishDto>> Handle(getAllDishQuery query, CancellationToken cancellationToken)
        {
            _logger.LogDebug("");

            var consulta = await _context.Dishes.ToListAsync();

            var result = _mapper.Map<List<DishDto>>(consulta);

            _logger.LogDebug("");

            return result;
        }


    }
}
