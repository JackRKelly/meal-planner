namespace MealPlanner.Models {
  public class Meal {
    public int ID {get; set;}
    public string Name {get; set;}
    public string Image {get; set;}
    public string[] Instructions {get; set;}
    public string[] Ingredients {get; set;}
  }
}