using AutoMapper;
using CodeCina.Application.Dtos.TypeProductsDto;
using CodeCina.Application.Interfaces;
using CodeCina.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Commands.TypeProducts
{
    public class AddProductTypeCommand : IRequest<ProductTypeDto>
    {
        public string? NameProductType { get; set; }
    }

    public class AddTypeProductCommandHandler : IRequestHandler<AddProductTypeCommand, ProductTypeDto>
    {

        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<AddTypeProductCommandHandler> _logger;

        public AddTypeProductCommandHandler(IApplicationDbContext context, IMapper mapper, ILogger<AddTypeProductCommandHandler> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProductTypeDto> Handle(AddProductTypeCommand request,CancellationToken cancellationToken)
        {
            _logger.LogDebug("");

            var consulta = _mapper.Map<ProductType>(request);

            await _context.ProductTypes.AddAsync(consulta);
            await _context.SaveChangesAsync(cancellationToken);

            _logger.LogDebug("");

            return _mapper.Map<ProductTypeDto>(request);

        }
    }
}
