using Nancy;
using System.Collections.Generic;
using AnagramApp.Objects;

namespace AnagramApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
            Post["/anagram"] = _ => {
                Anagram newAnagram = new Anagram(Request.Form["anagram-word"], Request.Form["list-words"]);
                newAnagram.AnagramContainsChecker();
                return View["anagram.cshtml", newAnagram.GetAnagramWordSort()];
            };
        }
    }
}
