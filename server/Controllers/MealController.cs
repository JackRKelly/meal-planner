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

    [HttpGet("{id}", Name = "GetMealById")]
    public ActionResult<MealReadDto> GetMealById(int id)
    {
      var mealResult = _repository.GetMealById(id);

      if (mealResult != null)
      {
        return Ok(_mapper.Map<MealReadDto>(mealResult));
      }

      return NotFound();
    }

    [HttpPost]
    public ActionResult<MealReadDto> CreateMeal(MealCreateDto mealCreateDto)
    {
      var mealModel = _mapper.Map<Meal>(mealCreateDto);
      _repository.CreateMeal(mealModel);
      _repository.SaveChanges();

      var mealReadDto = _mapper.Map<MealReadDto>(mealModel);

      return CreatedAtRoute(nameof(GetMealById), new { Id = mealReadDto.Id }, mealReadDto);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateMeal(int id, MealUpdateDto mealUpdateDto)
    {
      var mealModelFromRepo = _repository.GetMealById(id);
      if (mealModelFromRepo == null)
      {
        return NotFound();
      }

      _mapper.Map(mealUpdateDto, mealModelFromRepo);
      _repository.UpdateMeal(mealModelFromRepo);
      _repository.SaveChanges();

      return NoContent();
    }
  }
}