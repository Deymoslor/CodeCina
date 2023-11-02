using CodeCina.Application.Queries.MenuProducts;
using CodeCina.Application.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeCina.API.Controllers.MenuProductsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenuProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllMenuProducts")]
        public async Task<IActionResult> GetAllMenuProductsQuery()
        {
            try
            {
                var result = await _mediator.Send(new GetAllMenuProductsQuery());
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
        }
    }
}
