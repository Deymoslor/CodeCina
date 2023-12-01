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

namespace CodeCina.Application.Commands.Products
{
    public class EditProductCommand : IRequest<ProductDto>
    {
        public int IdProduct { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
        public bool? ProductState { get; set; }
        public int? IdTypeProduct { get; set; }
        public int? IdMeasure { get; set; }
    }

    public class EditProductCommandHandler : IRequestHandler<EditProductCommand, ProductDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<EditProductCommandHandler> _logger;

        public EditProductCommandHandler(IApplicationDbContext context,
            IMapper mapper, ILogger<EditProductCommandHandler> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProductDto> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("EditProductCommandHandler START");

            var consulta = await _context.Products.FirstOrDefaultAsync
                (x => x.IdProduct == request.IdProduct, cancellationToken);
            if (consulta == null)
            {
                throw new InvalidOperationException("No encontrado");
            }

            _mapper.Map(request, consulta);

            await _context.SaveChangesAsync(cancellationToken);

            _logger.LogDebug("EditProductCommandHandler FINISHED");

            return _mapper.Map<ProductDto>(consulta);
        }
    }
}
