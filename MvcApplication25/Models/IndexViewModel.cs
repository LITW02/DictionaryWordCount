using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication25.Models
{
    public class IndexViewModel
    {
        public string Text { get; set; }
        public Dictionary<char, int> WordCount { get; set; } 
    }
}