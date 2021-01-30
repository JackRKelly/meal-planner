using System.Collections.Generic;
using MealPlanner.Models;

namespace MealPlanner.Data
{
  public class MockMealPlanner : IMealPlanner
  {
    public IEnumerable<Meal> GetAllMeals()
    {
      var meals = new List<Meal>
      {
        new Meal {
          Id = 0,
          Name = "Meal from list",
          Image = "https://google.com",
          Instructions = new string[] { "Step 1", "Step 2" },
          Ingredients = new string[] { "Ingredient 1", "Ingredient 2" }
        },
        new Meal {
          Id = 1,
          Name = "Meal from list",
          Image = "https://google.com",
          Instructions = new string[] { "Step 3", "Step 4" },
          Ingredients = new string[] { "Ingredient 3", "Ingredient 4" }
        }
      };

      return meals;
    }

    public Meal GetMealById(int id)
    {
      return new Meal
      {
        Id = 0,
        Name = "Meal",
        Image = "https://google.com",
        Instructions = new string[] { "Step 1", "Step 2" },
        Ingredients = new string[] { "Ingredient 1", "Ingredient 2" }
      };
    }
  }
}