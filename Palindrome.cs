using System;
using System.Collections.Generic;

public class Palindrome
{
  public string UserInput;

  public Palindrome(string userInput)
  {
    UserInput = userInput;
  }

  public bool IsPalindrome()
  {
    List<char> Chars = new List<char>();
    for(int i = 0; i < UserInput.Length; i++)
    {
      if (!Char.IsWhiteSpace(UserInput[i]))
      {
        Chars.Add(UserInput[i]);
      }
    }
    for(int j = 0; j < Chars.Count; j++)
    {
      if (Chars[j] != Chars[Chars.Count-j-1])
      {
        return false;
      }
    }
    return true;
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter a potential Palindrome: ");
    string initialInput = Console.ReadLine();
    string input = initialInput.ToLower();
    Palindrome userInput = new Palindrome(input);
    if (userInput.IsPalindrome())
    {
      Console.WriteLine("It is a Palindrome!");
    }
    else
    {
      Console.WriteLine("Is not a Palindrome.");
    }

  }
}