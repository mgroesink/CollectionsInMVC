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
            people[0, 1] = "Marcel";
            people[0, 2] = "Roesink";
            people[1, 0] = "LGI01";
            people[1, 1] = "Loni";
            people[1, 2] = "Gojani";
            people[2, 0] = "BWD01";
            people[2, 1] = "Bert";
            people[2, 2] = "van de Woord";
            people[3, 0] = "WAG01";
            people[3, 1] = "Gerard";
            people[3, 2] = "Wargers";
            people[4, 0] = "PLN01";
            people[4, 1] = "Peter";
            people[4, 2] = "Lijten";
            ViewBag.Items = people;
            ViewBag.Cols = 3;
            ViewBag.Rows = 5;
            return View();
        }

        public IActionResult MyDictionary()
        {
            Dictionary<string , string> people = new Dictionary<string , string>();
            people.Add("RSK01", "Marcel Roesink");
            people.Add("PLN01", "Peter Lijten");
            people.Add("BWD01", "Bert van de Woord");
            people.Add("LGI01", "Loni Gojani");
            return View(people);
        }

        public IActionResult MyQueue()
        {
            Queue<string> people = new Queue<string>();
            people.Enqueue("Marcel Roesink");
            people.Enqueue("Peter Lijten");
            people.Enqueue("Bert van de Woord");
            people.Enqueue("Loni Gojani");
            return View(people);
        }

        public IActionResult MyStack()
        {
            Stack<string> people = new Stack<string>();
            people.Push("Marcel Roesink");
            people.Push("Peter Lijten");
            people.Push("Bert van de Woord");
            people.Push("Loni Gojani");
            return View(people);
        }
    }
}
