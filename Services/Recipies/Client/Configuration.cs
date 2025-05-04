using System;
using Microsoft.Extensions.DependencyInjection;


namespace Services.Recipies.Client
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRecipieClient(this IServiceCollection services)
        {
            services.AddHttpClient<RecipieClient>(client =>
            {
                client.BaseAddress = new Uri("https://dummyjson.com/");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            return services;
        }
    }
}
