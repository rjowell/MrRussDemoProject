using System;
class Program
{
  public static void Main (string[] args)
  {
    
    
    Console.WriteLine("Welcome to Derek's Rice House");
    Console.WriteLine("What kind of rice do you want?");
    Console.WriteLine("A - White Rice  B - Apple Rice  C - Floating Rice  D - Egg Rice");
    string userInput = Console.ReadLine();

    if(userInput == "A")
    {
      Console.WriteLine("Here is your White Rice");
    }
    else if(userInput == "B")
    {
      Console.WriteLine("Here is your Apple Rice");
    }
    else if(userInput == "C")
    {
      Console.WriteLine("Here is your Floating Rice");
    }
    else if(userInput == "D")
    {
      Console.WriteLine("Here is your Egg Rice");
    }
    else
    {
      Console.WriteLine("We don't have that, please try again!");
    }
    
    

    
  }

}



