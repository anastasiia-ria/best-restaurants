using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string CostRange { get; set; }
    public string Rating { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }

    public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }

    public virtual ICollection<Review> Reviews { get; set; }
  }
}