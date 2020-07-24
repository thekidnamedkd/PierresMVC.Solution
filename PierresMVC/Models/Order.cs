using System.Collections.Generic;

namespace PierresMVC.Models
{
  public class Order
  {
    public string Description { get; set; }
  private static List<Order> _instances = new List<Order> {};

    public Order(string description)
    {
      Description = description;
      _instances.Add(this); // New code.
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}