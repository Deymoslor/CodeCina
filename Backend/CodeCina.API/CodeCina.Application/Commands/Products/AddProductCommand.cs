using AutoMapper;
using CodeCina.Application.Dtos.Products;
using CodeCina.Application.Interfaces;
using CodeCina.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCina.Application.Commands.Products
{
    public class AddProductCommand : IRequest<ProductDto>
    {
        public string? Nombre { get; set; }
        public int? IdTipoProducto { get; set; }
        public int? Cantidad { get; set; }
        public int? IdMedida { get; set; }

    }

    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<AddProductCommandHandler> _logger;
        private readonly IMapper _mapper;

        public AddProductCommandHandler(IApplicationDbContext context, ILogger<AddProductCommandHandler> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(AddProductCommand query, CancellationToken cancellationToken)
        {
            _logger.LogDebug("AddProductCommand Started");
            var request = _mapper.Map<Product>(query);

            await _context.Products.AddAsync(request);
            await _context.SaveChangesAsync(cancellationToken);

            _logger.LogDebug("AddProductCommand Finished");

            return _mapper.Map<ProductDto>(request);
        }
    }

}
