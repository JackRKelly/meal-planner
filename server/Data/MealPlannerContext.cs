using MealPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanner.Data
{

  public class MealPlannerContext : DbContext
  {
    public MealPlannerContext(DbContextOptions<MealPlannerContext> opt) : base(opt)
    {

    }

    public DbSet<Meal> Meals { get; set; }
  }
}