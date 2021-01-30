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
    private readonly IMealPlanner _repository;

    public MealsController(IMealPlanner planner)
    {
      _repository = planner;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Meal>> GetAllMeals()
    {
      var mealResult = _repository.GetAllMeals();

      return Ok(mealResult);
    }


    [HttpGet("{id}")]
    public ActionResult<Meal> GetMealById(int id)
    {
      var mealResult = _repository.GetMealById(id);

      return Ok(mealResult);
    }
  }
}