using System.Collections.Generic;

namespace Services.Recipies.Models
{

        public class RecipeApiResponse
        {
            public List<Recipe> Recipes { get; set; } = new List<Recipe>();
            public int Total { get; set; }
            public int Skip { get; set; }
            public int Limit { get; set; }
        }

        public class Recipe
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public List<string> Ingredients { get; set; } = new List<string>();
            public List<string> Instructions { get; set; } = new List<string>();
            public int PrepTimeMinutes { get; set; }
            public int CookTimeMinutes { get; set; }
            public int Servings { get; set; }
            public string Difficulty { get; set; } = string.Empty;
            public string Cuisine { get; set; } = string.Empty;
            public int CaloriesPerServing { get; set; }
            public List<string> Tags { get; set; } = new List<string>();
            public int UserId { get; set; }
            public string Image { get; set; } = string.Empty;
            public float Rating { get; set; }
            public int ReviewCount { get; set; }
            public List<string> MealType { get; set; } = new List<string>();
        }

}
