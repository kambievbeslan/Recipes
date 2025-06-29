using FluentValidation;
using Microsoft.Extensions.Logging;
using Recipes.Contracts.Recipes;
using Recipes.Domain.Recipes;

namespace Recipes.Application.Recipes
{
    public class RecipesService : IRecipesService
    {
        private readonly IRecipesRepository _recipesRepository;
        private readonly ILogger<RecipesService> _logger;
        private readonly IValidator<CreateRecipeDto> _validator;

        public RecipesService(
            IRecipesRepository recipesRepository,
            ILogger<RecipesService> logger,
            IValidator<CreateRecipeDto> validator)
        {
            _recipesRepository = recipesRepository;
            _logger = logger;
            _validator = validator;
        }


        public async Task<Guid> Create(CreateRecipeDto recipeDto, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(recipeDto, cancellationToken);
            
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var recipeId = Guid.NewGuid();

            var recipe = new Recipe
            {
                Id = recipeId,
                Title = recipeDto.Title,
                Description = recipeDto.Description,
            };

            await _recipesRepository.AddAsync(recipe, cancellationToken);

            _logger.LogInformation("Recipe created with id {recipeId}", recipeId);

            return recipeId;
        }

        public async Task Update(UpdateRecipeDto updateDto, CancellationToken cancellationToken)
        {

        }
    }
}
