using System.ComponentModel.DataAnnotations;

namespace MealPlanner.Dtos
{
  public class MealCreateDto
  {
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    public string Image { get; set; }

    [Required]
    public string[] Instructions { get; set; }

    [Required]
    public string[] Ingredients { get; set; }
  }
}