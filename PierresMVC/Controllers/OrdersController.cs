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
      Order newOrder = new Order(description, price, date);
      return RedirectToAction("Index");
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