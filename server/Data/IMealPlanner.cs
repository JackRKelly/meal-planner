using System.Collections.Generic;
using MealPlanner.Models;

namespace MealPlanner.Data
{
  public interface IMealPlanner
  {
    IEnumerable<Meal> GetAllMeals();
    Meal GetMealById(int id);
  }
}