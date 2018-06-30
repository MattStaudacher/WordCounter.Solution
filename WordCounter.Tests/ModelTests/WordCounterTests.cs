using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatWordTests
  {
    [TestMethod]
    public void WordCount_ReturnZero_True()
    {

      string word = "seattle";
      string inputSentence = "Washington is beautiful";
      WordRepeat newWord = new WordRepeat(word);
      int result = 0;

      int expected = newWord.InputWords(inputSentence);

      Assert.AreEqual(result, expected);
    }
    [TestMethod]
    public void WordCount_ReturnTwo_True()
    {

      string word = "of";
      string inputSentence = "mother of dragons breaker of chains";
      WordRepeat newWord = new WordRepeat(word);
      int result = 2;

      int expected = newWord.InputWords(inputSentence);

      Assert.AreEqual(result, expected);
    }

    //test to make sure words are being lowercased so they can be compared
    [TestMethod]
    public void WordCount_ReturnTwo_False()
    {

      string word = "king";
      string inputSentence = "Jon Snow is the true KING of the North";
      WordRepeat newWord = new WordRepeat(word);
      int result = 1;

      int expected = newWord.InputWords(inputSentence);

      Assert.AreEqual(result, expected);
    }

    }
  }
