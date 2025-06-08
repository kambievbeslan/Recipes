using Microsoft.AspNetCore.Mvc;
using Recipes.Contracts;

namespace Recipes.Presenters
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRecipeDto recipeDto, CancellationToken cancellationToken)
        {
            return Ok("Recipe created");
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetRecipesDto recipesDto, CancellationToken cancellationToken)
        {
            return Ok("Recipes get");
        }

        [HttpGet("{recipeId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid recipeId, CancellationToken cancellationToken)
        {
            return Ok("Recipes get by id");
        }

        [HttpPut("{recipeId:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid recipeId, [FromBody]UpdateRecipeDto recipesDto, CancellationToken cancellationToken)
        {
            return Ok("Recipes updated");
        }

        [HttpDelete("{recipeId:guid}")]
        public async Task<IActionResult> DeleteById([FromRoute] Guid recipeId, CancellationToken cancellationToken)
        {
            return Ok("Recipes deleted");
        }
    }
}
