using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresMVC.Models;

namespace PierresMVC.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult show(int vendorId)
    {
      Dictionary <string, object> model = new Dictionary<string, object> ();
      Vendor selectedVendor = Vendor.Find(vendorId);
      List <Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDesc, string orderPrice, string orderDate)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDesc, orderPrice, orderDate);
      selectedVendor.AddOrder(newOrder);
      List<Order> vendorOrders = selectedVendor.Orders;
      Dictionary<string, object> model = new Dictionary<string, object> ();
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
  }
}