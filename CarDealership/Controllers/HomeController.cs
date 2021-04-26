using Microsoft.AspNetCore.Mvc;
using Dealership.Models;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Car testCar = new Car("1974 Volkswagen Thing", 1100, 368792);
      return View(testCar);
    }
  }
}