using System.Collections.Generic;
using MealPlanner.Models;

namespace MealPlanner.Data
{
  public interface IMealPlanner
  {
    IEnumerable<Meal> GetMeals();
    Meal GetMealById(int id);
  }
}