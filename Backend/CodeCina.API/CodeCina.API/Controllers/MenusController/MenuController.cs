using CodeCina.Application.Commands.TypeProducts;
using CodeCina.Application.Queries.Menu;
using CodeCina.Application.Queries.TypeProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeCina.API.Controllers.MenusController
{

    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenuController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getMenusQuery")]
        public async Task<IActionResult> getAllMenusQuery()
        {
            try
            {
                var result = await _mediator.Send(new getAllMenuQuery());
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }
    }
}
