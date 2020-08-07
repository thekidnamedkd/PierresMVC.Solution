using Microsoft.AspNetCore.Mvc;

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