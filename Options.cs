
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
      Console.Write("Enter the Product ID of the product you want to update: ");
      if (!int.TryParse(Console.ReadLine(), out int productId))
      {
          Console.WriteLine("Invalid Product ID. Please use a numeric value.");
          return;
      }

      // Find the product by ID
      Products productToUpdate = products.Find(p => p.ProductId == productId);

      if (productToUpdate == null)
      {
          Console.WriteLine("Product not found. Please check the Product ID.");
          return;
      }

      Console.WriteLine($"Updating Product: {productToUpdate.Name}");

      // Update Product Name
      Console.Write($"Enter new name (or press Enter to keep '{productToUpdate.Name}'): ");
      string newName = Console.ReadLine();
      if (!string.IsNullOrEmpty(newName))
      {
          productToUpdate.Name = newName;
      }

      // Update Product Price
      Console.Write($"Enter new price (or press Enter to keep {productToUpdate.Price}): ");
      string newPriceInput = Console.ReadLine();
      if (!string.IsNullOrEmpty(newPriceInput) && decimal.TryParse(newPriceInput, out decimal newPrice))
      {
          productToUpdate.Price = newPrice;
      }

      // Update Product Availability
      Console.Write($"Is the product available? (yes/no, or press Enter to keep '{productToUpdate.IsAvailable}') ");
      string newAvailability = Console.ReadLine();
      if (!string.IsNullOrEmpty(newAvailability))
      {
          productToUpdate.IsAvailable = newAvailability.ToLower() == "yes";
      }

      // Update Product Type
      Console.Write($"Enter new Product Type Name (or press Enter to keep '{productToUpdate.ProductType.Name}'): ");
      string newTypeName = Console.ReadLine();
      if (!string.IsNullOrEmpty(newTypeName))
      {
          productToUpdate.ProductType.Name = newTypeName;
      }

      Console.Write($"Enter new Product Type ID (or press Enter to keep {productToUpdate.ProductType.Id}): ");
      string newTypeIdInput = Console.ReadLine();
      if (!string.IsNullOrEmpty(newTypeIdInput) && int.TryParse(newTypeIdInput, out int newTypeId))
      {
          productToUpdate.ProductType.Id = newTypeId;
      }

      Console.WriteLine("Product updated successfully!");
      Console.WriteLine("-----------------------------------");
  }//close choice 4


    public static void choice4(List<Products> products)
    {
        Console.Write("Enter the Product ID of the product you want to remove: ");
        if (!int.TryParse(Console.ReadLine(), out int productId))
        {
            Console.WriteLine("Invalid Product ID. Please use a numeric value.");
            return;
        }

        // Find the product by ID
        Products productToRemove = products.Find(p => p.ProductId == productId);

        if (productToRemove == null)
        {
            Console.WriteLine("Product not found. Please check the Product ID.");
            return;
        }

        // Confirm removal
        Console.WriteLine($"Are you sure you want to remove '{productToRemove.Name}'? (yes/no): ");
        string confirmation = Console.ReadLine()?.ToLower();

        if (confirmation == "yes")
        {
            products.Remove(productToRemove);
            Console.WriteLine("Product removed successfully!");
        }
        else
        {
            Console.WriteLine("Product removal canceled.");
        }
    }//close choice4


  public static void choice5(List<Products> products)
  {
    Console.WriteLine("5");
  }//close choice5

}// close class 
