using MediatR;
using Microsoft.AspNetCore.Mvc;
using WonderfulStore.Application.Commands.AddProduct;

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
    }
}