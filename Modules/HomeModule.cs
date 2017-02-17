using Nancy;
using Anagram.Objects;
using System.Collections.Generic;

namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        List<string> fancyList = new List<string>{};
        string word2 = Request.Form["word2"];
        string word3 = Request.Form["word3"];
        fancyList.Add(word2);
        fancyList.Add(word3);
        BananaGram newBananaGram = new BananaGram(Request.Form["word1"], fancyList);
        return View["results.cshtml", newBananaGram];
      };
    }
  }
}
