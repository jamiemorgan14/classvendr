using System;
using classvendr.Models;

namespace classvendr
{
  class Program
  {
    static void Main(string[] args)
    {
      Snack doritos = new Snack("Doritos", 1.25m);
      System.Console.WriteLine($"{doritos.Name}: {doritos.Price}");
      doritos.UpdatePrice(1.50m);
      System.Console.WriteLine($"{doritos.Name}: {doritos.Price}");
    }
  }
}
