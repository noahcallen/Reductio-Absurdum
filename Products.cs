namespace Reductio;

public class Products
{
  public string Name { get; set; }
  public decimal Price { get; set; }
  public bool IsAvailable { get; set; }
  public int ProductId { get; set; }
  public ProductType ProductType { get; set; }


}

public class ProductType
{
  public string Name { get; set;}
  public int Id { get; set;}
}
