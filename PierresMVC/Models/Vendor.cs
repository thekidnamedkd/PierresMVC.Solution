using System.Collections.Generic;

namespace PierresMVC.Models
{
  public class Vendor
  {
    public int VendorId { get; }
    public string VendorDesc { get; set; }

    public Vendor(string description)
    {
      VendorDesc = description;
    }
  }
}