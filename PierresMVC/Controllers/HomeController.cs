using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
    public ActionResult Create(string description)
    {
      Order myOrder = new Order(description);
      return RedirectToAction("Index");
    }
  }
}