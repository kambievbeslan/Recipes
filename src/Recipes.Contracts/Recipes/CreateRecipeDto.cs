namespace Recipes.Contracts.Recipes
{
    public record CreateRecipeDto(string Title, string Description, Guid[] ProductIds);
}
