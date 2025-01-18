using Reductio;
using Options;
using System;
using System.Collections.Generic;

public class Program
{
  
  List<Products> products = new List<Products>
  {
    new Products {Name = "Great Wood", Price = 12.65M, IsAvailable = true, ProductId = 360,ProductType = new ProductType {Name = "Wand", Id = 1}},
    new Products {Name = "Scary Book", Price = 5.80M, IsAvailable = false, ProductId = 457, ProductType = new ProductType {Name = "Enchanted Item", Id = 2}},
    new Products {Name = "Thick Liquid", Price = 8.24M, IsAvailable = true, ProductId = 129, ProductType = new ProductType {Name = "Potion", Id = 3}},
    new Products {Name = "Nice Robe", Price = 34.95M, IsAvailable = true, ProductId = 543, ProductType = new ProductType {Name = "Apparel", Id = 4}}
  }; 

  public static void Main()
  {

    MenuFunction menuFunction = new MenuFunction();

    do
    {
    //Main Menu
    Console.WriteLine("Welcome To Reductio & Absurdum!");
    Console.WriteLine("=============Main Menu=============");
    Console.WriteLine(" 1. View All Products \n 2. Add a New Product \n 3. Update a Product \n 4. Remove a Product \n 5. Search By ProductId \n 6. Quit");
    Console.WriteLine("===================================");

    Console.Write("Enter a Number 1-6: ");
    menuFunction.userChoice = int.Parse(Console.ReadLine());

    switch (menuFunction.userChoice)
    {
      case 1:
      MenuFunction.choice1();
      break;

      case 2:
      MenuFunction.choice2();
      break;

      case 3:
      MenuFunction.choice3();
      break;

      case 4:
      MenuFunction.choice4();
      break;

      case 5:
      MenuFunction.choice5();
      break;
    }//close switch

    //CLOSE Main Menu

    } while (menuFunction.userChoice != 6);

  }//close Main

} //close class
