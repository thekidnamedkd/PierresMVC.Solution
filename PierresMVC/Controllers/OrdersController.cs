using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresMVC.Models;

namespace PierresMVC.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string description, string price, string date)
    {
      Order Order = new Order(description, price, date);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }

    [HttpGet("/orders/{OrderId}")]
    public ActionResult Show(int OrderId)
    {
      Order foundOrder = Order.Find(OrderId);
      return View(foundOrder);
    }
  }
}