using System.Collections.Generic;
using MealPlanner.Data;
using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
  [Route("api/meals")]
  [ApiController]
  public class MealsController : ControllerBase
  {
    private readonly MockMealPlanner _mockplanner = new MockMealPlanner();

    [HttpGet]
    public ActionResult<IEnumerable<Meal>> GetAllMeals()
    {
      var mealResult = _mockplanner.GetAllMeals();

      return Ok(mealResult);
    }


    [HttpGet("{id}")]
    public ActionResult<Meal> GetMealById(int id)
    {
      var mealResult = _mockplanner.GetMealById(id);

      return Ok(mealResult);
    }
  }
}