using CE.Chepeat.Domain.Aggregates.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CE.Chepeat.API.Controllers
{
    // En: CE.Chepeat.API.Controllers
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IApiController _appController;

        public ProductController(IApiController appController)
        {
            _appController = appController;
        }

        [HttpGet("GetProducts")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Authorize(Policy = "SELLER")]
        public async ValueTask<IActionResult> GetProducts()
        {
            return Ok(await _appController.ProductPresenter.GetProducts());
        }

        [HttpPost("AddProduct")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Authorize(Policy = "SELLER")]
        public async ValueTask<IActionResult> AddProduct([FromBody] ProductAggregate productAggregate)
        {
            return Ok(await _appController.ProductPresenter.AddProduct(productAggregate));
        }

        [HttpDelete("DeleteProduct")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Authorize(Policy = "SELLER")]
        public async ValueTask<IActionResult> DeleteProduct([FromBody] Guid id)
        {
            return Ok(await _appController.ProductPresenter.DeleteProduct(id));
        }

        [HttpPatch("UpdateProduct")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Authorize(Policy = "SELLER")]
        public async ValueTask<IActionResult> UpdateProduct([FromBody] ProductAggregate productAggregate)
        {
            return Ok(await _appController.ProductPresenter.UpdateProduct(productAggregate));
        }
    }
}
