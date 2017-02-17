using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Objects
{
  public class BananaGram
  {
    private string _word;
    private List<string> _anagramList  = new List<string>();

    public BananaGram(string word, List<string> wordList)
    {
      _word = word;
      _anagramList = wordList;
    }
    public string GetWord ()
    {
      return _word;
    }

    public List<string> ListOfAnagrams ()
    {
      return _anagramList;
    }

    public List<string> FirstAnagram ()
    {
      List<string> ReturnedWord = new List<string>();
      char[] array = _word.ToCharArray();
      Array.Sort(array);

      foreach (string word in _anagramList)
      {
        char[] listArray = word.ToCharArray();
        Array.Sort(listArray);

        if (array.SequenceEqual(listArray)) {
          ReturnedWord.Add(word);
        }
      }
      return ReturnedWord;
    }
  }
}
