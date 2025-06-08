namespace Recipes.Domain
{
    public class Recipe
    {
        public Guid Id { get; set; }

        public required string Title { get; set; }
        
        public required string Description { get; set; }

        public int Rating { get; set; } = default;
    }

    public class RecipeElement
    {
        public required Guid RecipeId { get; set; }

        public required Guid ProductId { get; set; }

        public required Guid MeasureId { get; set; }

        public required double Quantity { get; set; }
    }
}
