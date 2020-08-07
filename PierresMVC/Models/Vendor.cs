using System.Collections.Generic;

namespace PierresMVC.Models
{
  public class Vendor
  {
    public int Id { get; }
    public string VendorName { get; set; }
    public string VendorDesc { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public List<Order> Orders { get; set; }
    public Vendor(string name, string description)
    {
      VendorName = name;
      VendorDesc = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}