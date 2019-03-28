namespace classvendr.Models
{
  class Snack
  {
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public void UpdatePrice(decimal newPrice)
    {
      Price = newPrice;
    }
    public Snack(string name, decimal price)
    {
      Name = name;
      Price = price;
    }
  }
}