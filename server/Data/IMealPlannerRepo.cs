using System.Collections.Generic;
using MealPlanner.Models;

namespace MealPlanner.Data
{
  public interface IMealPlannerRepo
  {
    bool SaveChanges();
    IEnumerable<Meal> GetAllMeals();
    Meal GetMealById(int id);
    void CreateMeal(Meal meal);
    void UpdateMeal(Meal meal);
    void DeleteMeal(Meal meal);
  }
}