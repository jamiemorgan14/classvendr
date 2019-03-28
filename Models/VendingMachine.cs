using System;
using System.Collections.Generic;

namespace classvendr.Models
{
  class VendingMachine
  {

    private decimal TotalCash { get; set; }

    public decimal CurrentTransaction { get; private set; }

    private Dictionary<String, List<Snack>> Snacks { get; set; }

    private List<Electronic> Electronics { get; set; }

    #region

    public void AddItem(Snack snack)
    {
      Snacks.Add(snack);
    }

    public void AddItem(Electronic electronic)
    {
      Electronics.Add(electronic);
    }


    public void AddItem(Snack snack, int index)
    {
      Snacks.Insert(index, snack);
    }

    public void AddItem(Electronic electronic, int index)
    {
      Electronics.Insert(index, electronic);
    }
    #endregion

    public string AddQuarter()
    {
      CurrentTransaction += .25m;
      return CurrentTransaction.ToString();
    }

    public Snack Vend(int snackIndex)
    {
      if (snackIndex < 0 || snackIndex > Snacks.Count - 1)
      {
        Console.WriteLine("Invalid Selection");
        return null;
      }
      Snack selection = Snacks[snackIndex];
      if (CurrentTransaction >= selection.Price)
      {
        CurrentTransaction -= selection.Price;
        return selection;
      }
      System.Console.WriteLine("Not enough money");
      return null;
    }
    public VendingMachine()
    {
      Snacks = new List<Snack>();
    }
  }
}