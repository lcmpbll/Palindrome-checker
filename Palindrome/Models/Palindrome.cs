using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindrome
{
  public class Palindrome
  {
    public bool PalindromeChecker(string userInput)
    {
      string trimUserInput = userInput.Replace(" ", "");
      char[] userInputArray = (trimUserInput.ToLower()).ToCharArray();
      char[] reverseUserInputArray = Enumerable.Reverse(userInputArray).ToArray();
      bool isPalindrome = userInputArray.SequenceEqual(reverseUserInputArray);
      if (isPalindrome)
      {
        return true;
      }
        else 
      {
        return false;
      }  
    }
  }
}




// string MyString = " Big   ";
// Console.WriteLine("Hello{0}World!", MyString);
// string TrimString = MyString.Trim();
// Console.WriteLine("Hello{0}World!", TrimString);
//       The example displays the following output:
//             Hello Big   World!
//             HelloBigWorld!
//

// using System;
 
// public class Example
// {
//     public static void Main()
//     {
//         int[] array = { 2, 4, 6, 8 };
//         Array.Reverse(array);
 
//         Console.WriteLine(String.Join(',', array));
//     }
// }



