using System.Collections.Generic;
using AutoMapper;
using MealPlanner.Data;
using MealPlanner.Dtos;
using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
  [Route("api/meals")]
  [ApiController]
  public class MealController : ControllerBase
  {
    private readonly IMealPlanner _repository;
    private readonly IMapper _mapper;

    public MealController(IMealPlanner planner, IMapper mapper)
    {
      _repository = planner;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<MealReadDto>> GetAllMeals()
    {
      var mealResult = _repository.GetAllMeals();

      return Ok(_mapper.Map<IEnumerable<MealReadDto>>(mealResult));
    }

    [HttpGet("{id}")]
    public ActionResult<MealReadDto> GetMealById(int id)
    {
      var mealResult = _repository.GetMealById(id);

      if (mealResult != null)
      {
        return Ok(_mapper.Map<MealReadDto>(mealResult));
      }

      return NotFound();
    }
  }
}