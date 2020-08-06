using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMVC.Models;
using System.Collections.Generic;
using System;

namespace PierresMVC.Tests
{
  [TestClass]
  public class VendorTest
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsObjectProperties_String()
    {
      string name = "Cafe Coffeeland";
      string description = "Hip hangout";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.VendorName;
      string resultTwo = newVendor.VendorDesc;

      Assert.AreEqual(name, result);
      Assert.AreEqual(description, resultTwo);
    }
  }
}