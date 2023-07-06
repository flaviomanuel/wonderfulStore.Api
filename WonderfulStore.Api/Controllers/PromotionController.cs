using MediatR;
using Microsoft.AspNetCore.Mvc;
using WonderfulStore.Application.Queries.ListAllPromotionTypes;

namespace WonderfulStore.Api.Controllers
{
    [Route("api/[controller]")]
    public class PromotionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PromotionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("ListAllPromotionTypes")]
        public  async Task<IActionResult> ListAllPromotionTypes( ){
            var query = new ListAllPromotionTypesQuery();

            var result = await _mediator.Send(query);

            return Ok(result.ToList());
        }
    }
}
