using System;
using System.Collections.Generic;


namespace Reductio
{
  
public class Program
{
  
  List<Products> products = new List<Products>
  {

  }; 

  public static void Main()
  {
    int userChoice;

    do
    {
    //Main Menu
    Console.WriteLine("Welcome To Reductio & Absurdum!");
    Console.WriteLine("=============Main Menu=============");
    Console.WriteLine(" 1. View All Products \n 2. Add a New Product \n 3. Update a Product \n 4. Remove a Product \n 5. Quit");
    Console.WriteLine("===================================");

    userChoice = int.Parse(Console.ReadLine());

    
    //CLOSE Main Menu

    } while (userChoice != 5);
    
  }//close Main

} //close class

}// close namespace
