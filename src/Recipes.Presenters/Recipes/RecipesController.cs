using Microsoft.AspNetCore.Mvc;
using Recipes.Application.Recipes;
using Recipes.Contracts.Recipes;

namespace Recipes.Presenters.Recipes
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {

        private readonly IRecipesService _recipesService;

        public RecipesController(IRecipesService recipesService)
        {
            _recipesService = recipesService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRecipeDto recipeDto, CancellationToken cancellationToken)
        {
            var recipeId = await _recipesService.Create(recipeDto, cancellationToken).ConfigureAwait(false);

            return Ok(recipeId);
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
