using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList
{

  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }

    // static void listOps()
    // {
    //   bool active = true;
    //   bool firstRun = true; 
    //   Console.WriteLine("Welcome to the To Do List!!!!!");
    //   Console.WriteLine("(Add) to list or (View) list?:");
    //   string userInput = Console.ReadLine();
    //   while(active == true)
    //   {
    //     while(userInput != "Add" && userInput != "add" && userInput != "View" && userInput != "view")
    //     {
    //       Console.WriteLine("Please enter a valid input ('Add' or 'View'):");
    //       userInput = Console.ReadLine();
    //     }

    //     if(userInput == "add" || userInput == "Add")
    //     {
    //       Console.WriteLine("Enter description for to do list item to add:");
    //       userInput = Console.ReadLine();
    //       addItems(userInput);
    //       firstRun = false;
    //     } else if(userInput == "view" || userInput == "View")
    //     {
    //       if(firstRun == true)
    //       {
    //         Console.WriteLine("You have yet to add any items to your list, please add an item first before viewing.");
    //       } else
    //       {
    //         viewItems();
    //       }
    //     }

    //     Console.WriteLine("(Add) to list or (View) list?:");
    //     userInput = Console.ReadLine();
    //   }  
    // }

    // static Item addItems(string itemDesc)
    // {
    //   Item item = new Item(itemDesc);
    //   return item;
    // }

    // static void viewItems()
    // {
    //   int listIndex = 1;
    //   List<Item> result = Item.GetAll();
    //   foreach (Item thisItem in result)
    //   {
    //     Console.WriteLine(listIndex + ": " + thisItem.Description);
    //     listIndex++;
    //   }
    // }



  }
}