namespace classvendr.Models
{
  class Electronic
  {
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public void UpdatePrice(decimal newPrice)
    {
      Price = newPrice;
    }
    public Electronic(string name, decimal price)
    {
      Name = name;
      Price = price;
    }
  }
}