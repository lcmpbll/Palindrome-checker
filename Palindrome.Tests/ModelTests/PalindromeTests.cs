using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void PalindromeChecker_UserInputIsAPalindrome_True()
  {
    Palindrome testPalindrome = new Palindrome();
    Assert.AreEqual(true, testPalindrome.PalindromeChecker("1"));
  }
    [TestMethod]
    public void PalindromeChecker_UserInputIsAPalindrome_False()
  {
    Palindrome testPalindrome = new Palindrome();
    Assert.AreEqual(false, testPalindrome.PalindromeChecker("yahoo"));
  }
  [TestMethod]
    public void PalindromeChecker_UserInputIsAPalindromeMultiLetter_True()
  {
    Palindrome testPalindrome = new Palindrome();
    Assert.AreEqual(true, testPalindrome.PalindromeChecker("wow"));
  }
   [TestMethod]
    public void PalindromeChecker_UserInputIsAPalindromeCapitolLetter_True()
  {
    Palindrome testPalindrome = new Palindrome();
    Assert.AreEqual(true, testPalindrome.PalindromeChecker("Wow"));
  }
   [TestMethod]
    public void PalindromeChecker_UserInputIsAPalindromeMultipleWord_True()
  {
    Palindrome testPalindrome = new Palindrome();
    Assert.AreEqual(true, testPalindrome.PalindromeChecker("A man a plan a canal panama"));
  }
  }
}