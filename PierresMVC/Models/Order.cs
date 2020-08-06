using System.Collections.Generic;

namespace PierresMVC.Models
{
  public class Order
  {
    public int OrderId { get; }
    public string OrderDesc { get; set; }
    public string OrderPrice { get; set; }
    public string OrderDate { get; set; }
    
    private static List<Order> _instances = new List<Order> {};

    public Order(string description, string price, string date)
    {
      OrderId = _instances.Count;
      OrderDesc = description;
      OrderPrice = price;
      OrderDate = date;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}