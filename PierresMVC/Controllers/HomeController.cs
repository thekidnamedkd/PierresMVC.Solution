using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using PierresMVC.Models;

namespace PierresMVC.Controllers
{

  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {

      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpPost("/orders")]
    public ActionResult Create(string description, string price, string date)
    {
      Order myOrder = new Order(description, price, date);
      return RedirectToAction("Index");
    }
  }
}