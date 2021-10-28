using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebAPI.Models;

namespace MyWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string textInput)
        {
            List<string> list = textInput.ToLower().Split(' ').ToList(); 
            HashSet<string> hashList = new HashSet<string>();
            List<Text> listOfWords = new List<Text>();

            foreach (var word in list)
            {
                int count = list.Where(temp => temp.Equals(word))
                    .Select(temp => temp)
                    .Count();

                listOfWords.Add(new Text() { TextInput = word, WordCount = count });
            }
            List<Text> SortedList = listOfWords.OrderByDescending(o=>o.WordCount).ToList();
            foreach (Text item in SortedList)
            {
                hashList.Add(item.TextInput + ": " + item.WordCount);
            }
            List<string> lastList = hashList.ToList();
            ViewBag.hashList = lastList;
            
            return View();

        }
    }
}
