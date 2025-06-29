using FluentValidation;
using Recipes.Contracts.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Application.Recipes
{
    public class CreateRecipeValidator : AbstractValidator<CreateRecipeDto>
    {
        public CreateRecipeValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(100).WithMessage("Заголовок невалидный.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Рецепт не может быть пустым.");

            RuleFor(x => x.ProductIds).NotEmpty();
        }
    }
}
