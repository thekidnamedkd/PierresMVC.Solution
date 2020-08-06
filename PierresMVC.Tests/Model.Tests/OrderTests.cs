using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresMVC.Models;
using System;

namespace PierresMVC.Tests
{
  [TestClass]
  public class OrderTests :  IDisposable 
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Local SE Bakery, coffee + light";

      Order newOrder = new Order(description);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    { 
      string description = "Local SE Bakery, coffee + light";
      Order newOrder = new Order(description);

      string updatedDescription = "Local SE Bakery, coffee + light fare for families";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}