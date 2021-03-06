using System.Collections.Generic;

namespace PierresMVC.Models
{
  public class Order
  {
    public int Id { get; }
    public string OrderTitle { get; set; }
    public string OrderDesc { get; set; }
    public string OrderPrice { get; set; }
    public string OrderDate { get; set; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, string price, string date)
    {
      OrderTitle = title;
      OrderDesc = description;
      OrderPrice = price;
      OrderDate = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}