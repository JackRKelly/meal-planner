using AutoMapper;
using MealPlanner.Dtos;
using MealPlanner.Models;

namespace MealPlanner.Profiles
{
  public class MealProfile : Profile
  {
    public MealProfile()
    {
      CreateMap<Meal, MealReadDto>();
      CreateMap<MealCreateDto, Meal>();
    }
  }
}