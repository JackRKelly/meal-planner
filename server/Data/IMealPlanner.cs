using System.Collections.Generic;
using MealPlanner.Models;

namespace MealPlanner.Data
{
  public interface IMealPlanner
  {
    bool SaveChanges();
    IEnumerable<Meal> GetAllMeals();
    Meal GetMealById(int id);
    void CreateMeal(Meal meal);
  }
}