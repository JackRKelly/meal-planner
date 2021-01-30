namespace MealPlanner.Models {
  public class Meal {
    public int Id {get; set;}
    public string Name {get; set;}
    public string Image {get; set;}
    public string[] Instructions {get; set;}
    public string[] Ingredients {get; set;}
  }
}