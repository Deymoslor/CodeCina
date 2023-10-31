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
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public int? IdTipoProducto { get; set; }
        public int? Cantidad { get; set; }
        public int? IdMedida { get; set; }
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
                (x => x.IdProducto == request.IdProducto, cancellationToken);
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
