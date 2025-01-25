using Microsoft.VisualBasic;

namespace Reductio;

public class Products
{
  public string Name { get; set; }
  public decimal Price { get; set; }
  public bool IsAvailable { get; set; }
  public int ProductId { get; set; }
  public ProductType ProductType { get; set; }

  public DateTime DateStocked { get; set; }

  public int DaysOnShelf
{
    get
    {
        TimeSpan timeOnShelf = DateTime.Now - DateStocked;
        return timeOnShelf.Days;
    }
}
}

public class ProductType
{
  public string Name { get; set;}
  public int Id { get; set;}
}
