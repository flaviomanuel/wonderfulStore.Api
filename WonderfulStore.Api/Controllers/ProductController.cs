using MediatR;
using Microsoft.AspNetCore.Mvc;
using WonderfulStore.Application.Commands.AddProduct;
using WonderfulStore.Application.Commands.DeleteProduct;
using WonderfulStore.Application.Commands.GetByIdProduct;
using WonderfulStore.Application.Queries.GetAllProducts;

namespace WonderfulStore.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {    
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

         [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody]AddProductCommand command){
     
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(Add), new { id = id }, command);
        }

        
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(){
            var query  =  new GetAllProductsQuery();
            
            var products = await _mediator.Send(query);

            return Ok(products);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(GetByIdProductQuery query){
            var product = await _mediator.Send(query);

            return Ok(product);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id){
            var deleteProductCommand = new DeleteProductCommand(id);

            await _mediator.Send(deleteProductCommand);

            return Ok(new {id = deleteProductCommand.Id});
        }
    }
}