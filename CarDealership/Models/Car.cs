using System;
using System.Collections.Generic;


namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    private static List<Car> _instances = new List<Car> { };
    // public int Price { get; set; }
    // public int Miles { get; set; }

    public Car(string makeModel)
    {
      MakeModel = makeModel;
      // Price = price;
      // Miles = miles;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}