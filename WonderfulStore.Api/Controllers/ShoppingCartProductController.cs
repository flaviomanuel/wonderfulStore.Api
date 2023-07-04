using MediatR;
using Microsoft.AspNetCore.Mvc;
using WonderfulStore.Application.Commands.AddShoppingCartProduct;
using WonderfulStore.Application.Commands.DeleteProductInShoppingCart;
using WonderfulStore.Application.Queries.GetAllProductsFromShoppingCardById;

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

          
        [HttpGet("GetAllProductsFromShoppingCartById")]
        public async Task<IActionResult> GetAllProductsFromShoppingCart([FromQuery] GetAllProductsFromShoppingCartByIdQuery query){
           
           var result = await _mediator.Send(query);

            return CreatedAtAction(nameof(GetAllProductsFromShoppingCart), result);
        }

          [HttpDelete("DeleteProductInShoppingCart")]
        public async Task<IActionResult> DeleteProductInShoppingCart([FromQuery]DeleteProductInShoppingCartCommand command){
           
            await _mediator.Send(command);

            return Ok();
        }

    }
}