using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class Recipe
    {
        public int RecipesId { get; set; }
        public string RecipeName { get; set; }
        public string TypeofMeal { get; set; }
        public string MainIngredient { get; set; }
        public decimal CostPerServing { get; set; }
        public string PrepTime { get; set; }
    }
}
