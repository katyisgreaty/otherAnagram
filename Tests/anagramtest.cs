using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void ListOfAnagrams_ReturnAnagram_true()
    {
      List<string> anagramList = new List<string>{"bread", "board", "beard", "hello"};
      BananaGram bananaGramTest = new BananaGram("bared", anagramList);
      Assert.Equal(anagramList, bananaGramTest.ListOfAnagrams());
    }

    [Fact]
    public void FirstAnagram_CompareWord_true()
    {
      List<string> anagramList = new List<string>{"bread", "board", "beard", "hello"};
      BananaGram bananaGramTest = new BananaGram("bared", anagramList);
      List<string> returnedList = new List<string>{"bread", "beard"};
      Assert.Equal(returnedList, bananaGramTest.FirstAnagram());
    }
  }
}
