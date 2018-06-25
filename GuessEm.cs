// pick a number between 1-100
//
// app should then 'guess' a number
//
// ask whether the user's number is higher or lower than the 'guessed' number

using System;
using System.Collections.Generic;

class GuessNumber
{



  public bool playGame()
  {
    Console.WriteLine("Would like to play the game [y/n]");
    string answer = Console.ReadLine().ToLower();
    if (answer == "y" || false)
    {
        return true;
        highLow();
    }
    else
    {
      Console.WriteLine("Lets try again...");
      playGame();
      return false;
    }
  }

  public static highLow()
  {
    Console.WriteLine("Pick a sweet number between 1-100(in your brain)");
    Console.WriteLine("Is Your number Higer or Lower than 50 [h:igher/l:ower/c:orrect]");
    string higherLower = Console.ReadLine().ToLower();
    numbChucks(higherLower);
  }

  public static bool numbChucks(guess)
  {

    int compGuess = 50;
    while(guess != "c")
    {
      if(guess == "h")
      {
        compGuess = compGuess * 2;
      }
      else if(guess == "l")
      {
        compGuess = compGuess / 2;
      }
    }


  }


}
public class Program
{
  public static void Main()
  {
    GuessNumber newGuessNumber = new GuessNumber();
    newGuessNumber.playGame();
  }
}
