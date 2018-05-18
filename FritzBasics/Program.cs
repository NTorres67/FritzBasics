//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FritzBasics
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

// Copy and paste this into https://try.dot.net
// This is a good starting point for Sadukie's part in...
// C# Workshop at https://twitch.tv/csharpfritz
// Appearing May 18, 2018 at 11am ET

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        FritzApp myApp = new FritzApp();
        myApp.Run();
    }
}

class FritzApp
{
    public void Run()
    {
        // This part doesn't work in try.dot.net as of 2018-05-18.  So we'll work around this for now.
        // string userInput = "";
        // do
        // {
        // DisplayMenu();
        // userInput = Console.ReadLine();
        // } while (userInput.ToUpper() != "Q");
        // Console.WriteLine("Happy coding! Press any key to quit!");
        // Console.ReadKey();

        // Uncomment these as we go along
        // HelloYou("Your Name");
        // GetLunchIfElse();
        // GetLunchSwitch();
        // FlipCoin();
        // GoHide();
        // AllHid();
        // LaunchRocket();
        // GetSpaceCollections();
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Fritz Basics");
        Console.WriteLine("*************");
        Console.WriteLine("1. Hello World");
        Console.WriteLine("2. What's For Lunch - If...Else");
        Console.WriteLine("3. What's For Lunch - Switch");
        Console.WriteLine("4. Football Flip - If...Else with Random");
        Console.WriteLine("5. Hide and Seek - Loops");
        Console.WriteLine("6. All Hid - Loops");
        Console.WriteLine("7. Rocket Launch - Loops");
        Console.WriteLine("8. Space Adventures - Collections");
        Console.WriteLine("===============");
    }

    public void HelloYou(string name)
    {
        // String concatenation
        Console.WriteLine("Hello, " + name + "!");
        // String interpolation
        Console.WriteLine($"Hello {name}!");
    }

    public void GetLunchIfElse()
    {
        // Put the if ... else code here
        // If it's Tuesday - tacos
        // If it's Friday - pizza
        // If it's any other day - bacon
    }

    public void GetLunchSwitch()
    {
        // Put the switch code here          
        // If it's Tuesday - tacos
        // If it's Friday - pizza
        // If it's any other day - bacon
        string today = "Friday";
        switch (today)
        {
            case "Tuesday":
                Console.WriteLine("TACO TUESDAY!!!");
                break;
            case "Friday":
                Console.WriteLine("Pizza party!!!");
                break;
            default:
                Console.WriteLine();
        }
    }

    public void FlipCoin()
    {
        // Put the randomness here
        // Who will go first - Eagles (Jeff's team) or Browns (Sadukie's team)?
    }

    public void GoHide()
    {
        // In Hide-And-Seek, the counter has to count to a number to give people time to hide
        // Create a for-loop to do the counting to 20
        Console.WriteLine("=======================");
        for (int counter = 0; counter < 20; counter = counter++)
        {
            Console.Write(${ counter}\t);
    }
    Console.WriteLine("\n=======================");
    }

public void AllHid()
{
    // In Hide-And-Seek, there may be a song checking if they're all hid
    // "All hid, all hid, all hid... 5, 10, 15, 20 all hid"
    // Create a for-loop to show how to count up by 5s

    Console.WriteLine("=======================");
    for (int counter = 0; counter <= 20; counter = counter += 5) // shorthad for counter = counter + 5
    {
        Console.Write(${ counter}\t);
}
Console.WriteLine("\n=======================");
    }

    public void LaunchRocket()
{
    // When rockets launch, there's a countdown
    // Create a for-loop to show how to count down from 10

    Console.WriteLine("=======================");
    for (int countdownTimer = 10; countdownTimer > 0; countdownTimer--)
    {

    }
}

public void GetSpaceCollections()
{
    // Let's talk about planet objects and values
    // Lots of statistics at https://nssdc.gsfc.nasa.gov/planetary/factsheet/
}


}
