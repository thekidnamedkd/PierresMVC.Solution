using System.Collections.Generic;

namespace PierresMVC.Models
{
  public class Vendor
  {
    public int VendorId { get; }
    public string VendorName { get; set; }
    public string VendorDesc { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public List<Order> Order { get; set; }
    public Vendor(string name, string description)
    {
      VendorName = name;
      VendorDesc = description;
      _instances.Add(this);
      VendorId = _instances.Count;
      Order = new List<Order>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchVendorId)
    {
      return _instances[searchVendorId-1];
    }
  }
}