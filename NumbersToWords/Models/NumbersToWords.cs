using System;
using System.Collections.Generic;

namespace NumberReturner
{
  public class Number 
  {
    public static Dictionary<char, string> ones = new Dictionary<char, string>{{'1',"one"},{'2',"two"},{'3',"three"}};
    // Dictionary<char, string> elevenToNineteen = new Dictionary<string, string>();
    public static Dictionary<char, string> tens = new Dictionary<char, string>{{'2',"twenty"},{'3',"thirty"},{'4',"fourty"}};
   
  public static string numToWordTens(int numberFromUser)
  {
    // if (numberFromUser.ToString().Length < 2 )
    // {
    //    string singleDigit = ones[(char)numberFromUser];
    //    return singleDigit;
    // }
    // else if (numberFromUser.ToString.Length() < 3 && numberFromUser < 20)
    // {
    //   string twoDigits = elevenToNineteen[numberFromUser];
    //   return twoDigits;
    // }
    // 
     if (numberFromUser.ToString().Length < 3 && numberFromUser > 20)
    {
      char [] characters = numberFromUser.ToString().ToCharArray();
      string addto = "";
      foreach(char singles in characters)
      {
        if (characters[0] == characters[1])
        {
          addto += tens[singles];
          addto += ones[characters[1]];
          break;
        }
        else if(characters[0] == singles)
        {
          // send to tens dictionary
           addto += tens[singles];
        }
        else if(characters[1] == singles)
        {
          // send to ones dictionary
           addto += ones[singles];
        }
      }
      return addto;
    }
    else {
      string whatever = "hyeah";
      return whatever;
    }
  }
  }
}
