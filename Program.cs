using System;
using classvendr.Models;

namespace classvendr
{
  class Program
  {
    static void Main(string[] args)
    {
      Snack doritos = new Snack("Doritos", 1.25m);
      Snack mtDew = new Snack("Mt. Dew", 2.00m);
      Snack goldfish = new Snack("Goldfish", .50m);
      Electronic iPhone = new Electronic("iPhone", 900.99m);


      VendingMachine vm = new VendingMachine();
      vm.AddItem(doritos);
      vm.AddItem(mtDew);
      vm.AddItem(goldfish, 0);
      vm.AddItem(iPhone);

      System.Console.WriteLine();
    }
  }
}
