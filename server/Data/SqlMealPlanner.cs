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

    public void CreateMeal(Meal meal)
    {
      if (meal == null)
      {
        throw new System.ArgumentNullException(nameof(meal));
      }

      _context.Meals.Add(meal);
      if (!this.SaveChanges())
      {
        throw new System.ApplicationException();
      }
    }

    public IEnumerable<Meal> GetAllMeals()
    {
      return _context.Meals.ToList();
    }

    public Meal GetMealById(int id)
    {
      return _context.Meals.FirstOrDefault(p => p.Id == id);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }
  }
}