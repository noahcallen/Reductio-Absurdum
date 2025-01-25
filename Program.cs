using Reductio;
using Options;
using System;
using System.Collections.Generic;

namespace MainConsole;
public class Program
{

   List<Products> products = new List<Products>
  {
    new Products {Name = "Great Wood", Price = 12.65M, IsAvailable = true, ProductId = 360,ProductType = new ProductType {Name = "Wand", Id = 1}, DateStocked = DateTime.Now.AddDays(-3) },
    new Products {Name = "Scary Book", Price = 5.80M, IsAvailable = false, ProductId = 457, ProductType = new ProductType {Name = "Enchanted Item", Id = 2}, DateStocked = DateTime.Now.AddDays(-345)},
    new Products {Name = "Thick Liquid", Price = 8.24M, IsAvailable = true, ProductId = 129, ProductType = new ProductType {Name = "Potion", Id = 3}, DateStocked = DateTime.Now.AddDays(-7000)},
    new Products {Name = "Nice Robe", Price = 34.95M, IsAvailable = true, ProductId = 543, ProductType = new ProductType {Name = "Apparel", Id = 4},DateStocked = DateTime.Now.AddDays(-10)}
  }; 

  public static void Main()
  {

    Program program = new Program();
    MenuFunction menuFunction = new MenuFunction();

    do
    {
    //Main Menu
    Console.WriteLine("Welcome To Reductio & Absurdum!");
    Console.WriteLine("=============Main Menu=============");
    Console.WriteLine(" 1. View All Products \n 2. Add a New Product \n 3. Update a Product \n 4. Remove a Product \n 5. Search By ProductId \n 6. All Available Products \n 7. Quit");
    Console.WriteLine("===================================");

    Console.Write("Enter a Number 1-7: ");
    menuFunction.userChoice = int.Parse(Console.ReadLine());

    switch (menuFunction.userChoice)
    {
      case 1:
      MenuFunction.choice1(program.products);
      break;

      case 2:
      MenuFunction.choice2(program.products);
      break;

      case 3:
      MenuFunction.choice3(program.products);
      break;

      case 4:
      MenuFunction.choice4(program.products);
      break;

      case 5:
      MenuFunction.choice5(program.products);
      break;

      case 6:
      MenuFunction.choice6(program.products);
      break;
    }//close switch

    //CLOSE Main Menu

    } while (menuFunction.userChoice != 7);

  }//close Main

} //close class
