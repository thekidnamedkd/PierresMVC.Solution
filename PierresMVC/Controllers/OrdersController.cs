using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresMVC.Models;

namespace PierresMVC.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId, string orderDesc, string orderPrice)
    {
      Order orders = Order.Find(orderId);
      Vendor vendors = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", orders);
      model.Add("vendors", vendors);
      return View(model);
    }
  }
}