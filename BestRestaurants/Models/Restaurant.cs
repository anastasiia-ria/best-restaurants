namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string CostRange { get; set; }
    public string Rating { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }

    // public enum RatingList
    // {
    //   One, Two, Three, Four, Five
    // }
  }
}