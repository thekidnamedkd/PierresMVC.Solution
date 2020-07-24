using Microsoft.AspNetCore.Mvc;
using PierresMVC.Models;

namespace PierresMVC.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() 
    { 
      return View(); 
    }
  }
}