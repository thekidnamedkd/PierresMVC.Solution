namespace PierresMVC.Models
{
  public class Order
  {
    public string Description { get; }

    public Order(string description)
    {
      Description = description;
    }
  }
}