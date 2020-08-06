using System.Collections.Generic;

namespace PierresMVC.Models
{
  public class Vendor
  {
    public int VendorId { get; }
    public string VendorName { get; set; }
    public string VendorDesc { get; set; }

    public Vendor(string description, string name)
    {
      VendorName = name;
      VendorDesc = description;
    }
  }
}