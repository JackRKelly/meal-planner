using System.Collections.Generic;
using System.Linq;
using MealPlanner.Models;

namespace MealPlanner.Data
{
  public class SqlMealPlanner : IMealPlanner
  {
    private readonly MealPlannerContext _context;

    public SqlMealPlanner(MealPlannerContext context)
    {
      _context = context;
    }

    public IEnumerable<Meal> GetAllMeals()
    {
      return _context.Meals.ToList();
    }

    public Meal GetMealById(int id)
    {
      return _context.Meals.FirstOrDefault(p => p.Id == id);
    }
  }
}