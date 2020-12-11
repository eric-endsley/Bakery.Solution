using System;
using System.Collections.Generic;

namespace NTW 
{
  public class NumberWord
  {
    private static Dictionary<int, string> singleDigits = new Dictionary<int, string> ()
    { 
      {1, "one"}, 
      {2, "two"}, 
      {3, "three"}, 
      {4, "four"}, 
      {5, "five"}, 
      {6, "six"}, 
      {7, "seven"}, 
      {8, "eight"}, 
      {9, "nine"} 
    };
    
    public static string Convert(int number)
    {
      if(singleDigits.ContainsKey(number))
      {
          return (singleDigits[number]);
      }
      else
      {
          return "error";
      }
    }
  }
}