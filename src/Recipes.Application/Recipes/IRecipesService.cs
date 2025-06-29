using Recipes.Contracts.Recipes;

namespace Recipes.Application.Recipes
{
    public interface IRecipesService
    {
        Task<Guid> Create(CreateRecipeDto recipeDto, CancellationToken cancellationToken);
    }
}