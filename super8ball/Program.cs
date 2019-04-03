using System;

public class Super8ball
{

  static void Main()
  {

    System.Console.ForegroundColor = System.ConsoleColor.Cyan;
    System.Console.BackgroundColor = System.ConsoleColor.Black;

    string text = System.IO.File.ReadAllText(@"C:\Users\jgali\Dropbox\CodingDojo\csharp\super8ball\welcome.txt");

    // Display the file contents to the console. Variable text is a string.
    System.Console.WriteLine("{0}", text);

    // Keep the console window open in debug mode.
    System.Console.WriteLine("Please enter your name");

    String s;
    int ctr = 0;
    do
    {
      ctr++;
      s = System.Console.ReadLine();
      System.Console.WriteLine("Welcome to Magic 8 Ball {1}. You are about to recieve your fortune.", ctr, s);
      System.Console.WriteLine("{0}", text);
    } while (s != null);


    System.Console.WriteLine("---");
    System.Console.WriteLine("Please ask me a question");
  }



}