
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
    Console.WriteLine("2");
  }//close choice2

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
