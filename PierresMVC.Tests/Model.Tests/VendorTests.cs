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
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}