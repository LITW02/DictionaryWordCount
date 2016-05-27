using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication25.Models;

namespace MvcApplication25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string text)
        {
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.Text = text;
            if (!String.IsNullOrEmpty(text))
            {
                viewModel.WordCount = GetWordCount(text);
            }
            return View(viewModel);
        }


        private Dictionary<char, int> GetWordCount(string text)
        {
            Dictionary<char, int> results = new Dictionary<char, int>();
            foreach (char c in "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
            {
                results.Add(c, 0);
            }

            foreach (char c in text.ToUpper())
            {
                if (results.ContainsKey(c))
                {
                    results[c]++;
                }
            }

            return results;
        }
    }
}
