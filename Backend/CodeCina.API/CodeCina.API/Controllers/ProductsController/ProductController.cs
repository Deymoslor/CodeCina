using CodeCina.Application.Commands.Products;
using CodeCina.Application.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeCina.API.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProductsQuery ()
        {
            try
            {
                var result = await _mediator.Send(new getAllProductsQuery());
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
        }

        [HttpGet]
        [Route("GetByIdProduct/{id}")]
        public async Task<IActionResult> GetByIdProductQuery(int id)
        {
            try
            {
                var result = await _mediator.Send(new GetByIdProductQuery{ IdProducto  = id});
                if (result == null)
                {
                    return NotFound();
                }
                else { return Ok(result); }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error {ex.Message}", ex);
            }
        }

        [HttpPost]
        [Route("AddProduct")]
        public async Task<IActionResult> AddProductCommand (AddProductCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                if (result == null)
                {
                    return NotFound();
                }
                else { return Ok(result); }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error {ex.Message}", ex);
            }
        }

        [HttpPut]
        [Route("EditProduct")]
        public async Task<IActionResult> EditProductCommand(EditProductCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                if (result == null)
                {
                    return NotFound();
                }
                else { return Ok(result); }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error {ex.Message}", ex);
            }
        }
    }
}
