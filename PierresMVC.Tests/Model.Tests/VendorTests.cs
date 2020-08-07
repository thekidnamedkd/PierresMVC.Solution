using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMVC.Models;
using System.Collections.Generic;
using System;

namespace PierresMVC.Tests 
{

  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      string name = "Cafe Coffeland";
      string description = "Hip hangout";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnAllVendorObjects_VendorList()
    {
      string name = "Cafe Coffeland";
      string description = "Hip hangout";
      string nameTwo = "Joe's Java";
      string descriptionTwo = "Hot sludge";
      Vendor newVendor = new Vendor(name, description);
      Vendor newVendorTwo = new Vendor(nameTwo, descriptionTwo);
      List<Vendor> list = new List<Vendor> {newVendor, newVendorTwo};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(list, result);
    }
  }
}