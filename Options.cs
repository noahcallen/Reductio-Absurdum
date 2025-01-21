
using Reductio;
using MainConsole;
using System;

namespace Options;

public class MenuFunction
{
  public int userChoice;

  public static void choice1(List<Products> products)
  {
    Console.WriteLine("All Products: ");
    foreach (var product in products)
    {
      Console.WriteLine($"- {product.Name}");
    }//close foreach
    Console.WriteLine("-----------------------------------");
  }//close choice1

  public static void choice2(List<Products> products)
  {
      Console.Write("Enter Product Name: ");
      string name = Console.ReadLine();

      Console.Write("Enter Product Price (x.xx): ");
      if (!decimal.TryParse(Console.ReadLine(), out decimal price))
      {
          Console.WriteLine("Invalid price format. Please use a numeric value like 12.34.");
          return;
      }

      Console.Write("Enter Product Id (xxx): ");
      if (!int.TryParse(Console.ReadLine(), out int productId))
      {
          Console.WriteLine("Invalid product ID format. Please use a numeric value like 123.");
          return;
      }

      // By default, set the product as available
      bool isAvailable = true;

      Console.Write("Enter Product Type Name: ");
      string typeName = Console.ReadLine();

      Console.Write("Enter Product Type Id: ");
      if (!int.TryParse(Console.ReadLine(), out int typeId))
      {
          Console.WriteLine("Invalid product type ID format. Please use a numeric value like 1.");
          return;
      }

      // Create the ProductType object
      ProductType productType = new ProductType
      {
          Name = typeName,
          Id = typeId
      };

      // Create the new Product object
      Products newProduct = new Products
      {
          Name = name,
          Price = price,
          ProductId = productId,
          IsAvailable = isAvailable,
          ProductType = productType
      };

      // Add the new product to the list
      products.Add(newProduct);

      Console.WriteLine("New product added successfully!");
      Console.WriteLine("-----------------------------------");

  }// close choice 2


  public static void choice3(List<Products> products)
  {
    Console.WriteLine("3");
  }//close choice3

  public static void choice4(List<Products> products)
  {
    Console.WriteLine("4");
  }//close choice4

  public static void choice5(List<Products> products)
  {
    Console.WriteLine("5");
  }//close choice5

}// close class 
