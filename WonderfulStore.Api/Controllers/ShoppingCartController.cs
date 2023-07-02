using MediatR;
using Microsoft.AspNetCore.Mvc;
using WonderfulStore.Application.Commands.AddShoppingCart;

namespace WonderfulStore.Api.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ShoppingCartController(IMediator mediator)
        {
            _mediator = mediator;
        }

        
        [HttpPost("Add")]
        public async Task<IActionResult> Add(){
            var command =  new AddShoppingCartCommand();

            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(Add), new { id = id });
        }
    }
}