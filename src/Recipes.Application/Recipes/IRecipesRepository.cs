using Recipes.Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Application.Recipes
{
    public interface IRecipesRepository
    {
        Task<Guid> AddAsync(Recipe recipe, CancellationToken cancellationToken);

        Task<Guid> SaveAsync(Recipe recipe, CancellationToken cancellationToken);

        Task<Guid> DeleteAsync(Guid recipeId, CancellationToken cancellationToken);

        Task<Recipe> GetByIdAsync(Guid recipeId, CancellationToken cancellationToken);
    }
}
