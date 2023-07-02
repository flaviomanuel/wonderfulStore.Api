using MediatR;
using Microsoft.AspNetCore.Mvc;
using WonderfulStore.Application.Commands.AddShoppingCartProduct;

namespace WonderfulStore.Api.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingCartProductController : Controller
    {
        
        private readonly IMediator _mediator;
        public ShoppingCartProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost("AddProductInShoppingCart")]
        public async Task<IActionResult> AddProductInShoppingCart([FromBody] AddShoppingCartProductCommand command){
           
           var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(AddProductInShoppingCart), result);
        }
    }
}