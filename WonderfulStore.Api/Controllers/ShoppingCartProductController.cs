using MediatR;
using Microsoft.AspNetCore.Mvc;
using WonderfulStore.Application.Commands.AddShoppingCartProduct;
using WonderfulStore.Application.Commands.DeleteProductInShoppingCart;
using WonderfulStore.Application.Commands.UpdateProductQuantityInShoppingCart;
using WonderfulStore.Application.Queries.GetAllProductsFromShoppingCardById;
using WonderfulStore.Application.ViewModels;

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


        [HttpPut("UpdateQuantityOfProduct")]
        public async Task<IActionResult> UpdateQuantityOfProduct([FromQuery]Guid idProduct, Guid idShoppingCart,  [FromBody] UpdateQuantityOfProductViewModel updateQuantityOfProduct){
        var command = new UpdateProductQuantityInShoppingCartCommand(idProduct,idShoppingCart, updateQuantityOfProduct.Quantity);
          
          var result =  await _mediator.Send(command);

            return Ok(result);
        }

    }
}