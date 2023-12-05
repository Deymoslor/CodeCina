using CodeCina.Application.Commands.TypeProducts;
using CodeCina.Application.Queries.TypeProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeCina.API.Controllers.TypeProductsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TypeProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getAllTypeProductsQuery")]
        public async Task<IActionResult> getAllTypeProductsQuery()
        {
            try
            {
                var result = await _mediator.Send(new getAllTypeProductsQuery());
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }


        [HttpPost]
        [Route("addATypeProductCommand")]
        public async Task<IActionResult> addATypeProductCommand(AddProductTypeCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }
    }
}
