using Microsoft.AspNetCore.Mvc;

namespace CollectionsInMVC.Controllers
{
    public class DemoController : Controller
    {
        Random r = new Random();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult My1DArray()
        {
            // Array heeft vaste grootte en is van één type
            int[] numbers = new int[10]; // array for 10 integers
            for(int i = 0; i < 10; i++)
            {
                numbers[i] = r.Next(100 , 1000); // random number between 99 and 1000
            }
            ViewBag.Items = numbers;
            return View("Output");
        }

        public IActionResult My2DArray()
        {
            string[,] people = new string[5, 3];
            people[0, 0] = "RSK01";
            people[0, 1] = "Maximiliaan";
            people[0, 2] = "Roosendaal";
            people[1, 0] = "LGI01";
            people[1, 1] = "Leo";
            people[1, 2] = "van der Graaf";
            people[2, 0] = "BWD01";
            people[2, 1] = "Bram";
            people[2, 2] = "Willemsen";
            people[3, 0] = "WAG01";
            people[3, 1] = "Gonny";
            people[3, 2] = "Waanders";
            people[4, 0] = "PLN01";
            people[4, 1] = "Patrick";
            people[4, 2] = "van Laar";
            ViewBag.Items = people;
            ViewBag.Cols = 3;
            ViewBag.Rows = 5;
            return View();
        }

        public IActionResult MyDictionary()
        {
            Dictionary<string , string> people = new Dictionary<string , string>();
            people.Add("RSK01", "Maximiliaan Roosendaal");
            people.Add("PLN01", "Patrick van Laar");
            people.Add("BWD01", "Bram Willemsen");
            people.Add("LGI01", "Leo van der Graaf");
            return View(people);
        }

        public IActionResult MyQueue()
        {
            Queue<string> people = new Queue<string>();
            people.Enqueue("Maximiliaan Roosendaal");
            people.Enqueue("Patrick van Laar");
            people.Enqueue("Bram Willemsen");
            people.Enqueue("Leo van der Graaf");
            return View(people);
        }

        public IActionResult MyStack()
        {
            Stack<string> people = new Stack<string>();
            people.Push("Maximiliaan Roosendaal");
            people.Push("Patrick van Laar");
            people.Push("Bram Willemsen");
            people.Push("Leo van der Graaf");
            return View(people);
        }
    }
}
