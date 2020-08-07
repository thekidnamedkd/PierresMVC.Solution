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
      Order newOrder = new Order("test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsObjectProperties_String()
    {
      string description = "Bread and Pastries";
      string price = "$90";
      string date = "08.05.20";

      Order newOrder = new Order(description, price, date);
      string result = newOrder.OrderDesc;

      Assert.AreEqual(description, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsInstanceofOrder_OrderList()
    {
      string description = "Bread and Pastries";
      string price = "$90";
      string date = "08.05.20";
      Order newOrder = new Order(description, price, date);
      
      int result = newOrder.OrderId;
    
      Assert.AreEqual(1, result);
    }

  [TestMethod]
  public void Find_ReturnsCorrectOrder_Order()
  {
    string description = "Bread and Pastries";
    string price = "$90";
    string date = "08.05.20";
    string descriptionTwo = "Just pastries";
    string priceTwo = "$35";
    string dateTwo = "08.02.20";
    Order newOrder = new Order(description, price, date);
    Order newOrderTwo = new Order(descriptionTwo, priceTwo, dateTwo);

    Order result = Order.Find(2);

    Assert.AreEqual(newOrderTwo, result);
  }

    [TestMethod]
    public void GetAll_ReturnAllOrderObjects_OrderList()
    {
      string description = "Bread and Pastries";
      string price = "$90";
      string date = "08.05.20";
      string descriptionTwo = "Just pastries";
      string priceTwo = "$35";
      string dateTwo = "08.02.20";
      Order newOrder = new Order(description, price, date);
      Order newOrderTwo = new Order(descriptionTwo, priceTwo, dateTwo);
      List<Order> list = new List<Order> {newOrder, newOrderTwo};
      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(list, result);
    }
  }
}