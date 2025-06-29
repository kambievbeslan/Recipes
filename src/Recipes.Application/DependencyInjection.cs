using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Recipes.Application.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

            services.AddScoped<IRecipesService, RecipesService>();

            return services;
        }
    }
}
