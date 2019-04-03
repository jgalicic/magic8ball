using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace super8Ball
{


  public class Super8ball
  {

    static void Main(string[] args)
    {
      ConsoleColor oldColor = Console.ForegroundColor; 
      System.Console.ForegroundColor = System.ConsoleColor.Cyan;
      System.Console.BackgroundColor = System.ConsoleColor.Black;

      string welcome = System.IO.File.ReadAllText(@"../welcome.txt");
      System.Console.WriteLine("{0}", welcome);


      
      ProgramName();

      Random randomObject = new Random();
      while(true)
      {
        string questionString = GetQuestionFromUser();

        int numberOfSecondsToSleep = randomObject.Next(2)+1;
        System.Console.WriteLine("Thinking about your answer, stand by...");
        Thread.Sleep(numberOfSecondsToSleep * 1000);

        if (questionString.Length == 0)
        {
          System.Console.WriteLine("You need to type a question! I can't read minds!");
          continue;
        }

        //Exits out of question
        if (questionString.ToLower() == "quit")
        {
          break;
        }
        
        //joke
        if (questionString.ToLower() == "you suck")
        {
          System.Console.WriteLine("You suck even more! Bye!");
          break;
        }
        // System.Console.WriteLine("{0}", randomObject.Next(10)+1);
        int randomNumber = randomObject.Next(6);
        //use random numnber to determine response
        switch(randomNumber)
        {
          case 0: 
            {
              // System.Console.WriteLine("NullReference Exception");
              string text = System.IO.File.ReadAllText(@"../1.txt");
              System.Console.WriteLine("{0}", text);
              break;
            }
          case 1: 
            {
              // System.Console.WriteLine("Your questions is very important to us, please wait as I pretend to care.");
              string text = System.IO.File.ReadAllText(@"../2.txt");
              System.Console.WriteLine("{0}", text);
              break;
            }
          case 2:
            {
              // System.Console.WriteLine("I'm Batmaaaan!");
              string text = System.IO.File.ReadAllText(@"../3.txt");
              System.Console.WriteLine("{0}", text);
              break;
            }
          case 3:
            {
              // System.Console.WriteLine("Ask again never");
              string text = System.IO.File.ReadAllText(@"../4.txt");
              System.Console.WriteLine("{0}", text);
              break;
            }
          case 4:
            {
              // System.Console.WriteLine("You were expecting me to say yes or no, weren't you? Surprised you, haven't I?");
              string text = System.IO.File.ReadAllText(@"../5.txt");
              System.Console.WriteLine("{0}", text);
              break;
            }
          case 5:
            {
              string text = System.IO.File.ReadAllText(@"../6.txt");
              System.Console.WriteLine("{0}", text);
              // System.Console.WriteLine("Out of over 7 billion people on this planet, you decided to ask me?");
              break;
            }
          // case 6:
          //   {
          //     System.Console.WriteLine("I'm literally an ASCII 8 ball. What are you expecting, the answer to life?");
          //     break;
          //   }
          // case 7:
          //   {
          //     System.Console.WriteLine("Error 404: Answer not found, try again!");
          //     break;
          //   }
        }
      }
      
      Console.ForegroundColor = oldColor;

    }
    public static void ProgramName()
    {
      System.Console.WriteLine("Magic 8 Ball (by: Justin, Pierre, Raymond)");
    }

    public static string GetQuestionFromUser()
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("Ask a question?: ");
      Console.ForegroundColor = ConsoleColor.Cyan;
      string questionString = Console.ReadLine();

      return questionString;
    }



  }
}