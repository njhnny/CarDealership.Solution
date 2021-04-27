using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Car addCar = new Car("Add first car to the Lot List");
      return View(addCar);
    }

    [Route("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/cars")]
    public ActionResult Create(string makeModel)
    {
      Car newCar = new Car(makeModel);
      return View("Index", newCar);
    }
  }
}