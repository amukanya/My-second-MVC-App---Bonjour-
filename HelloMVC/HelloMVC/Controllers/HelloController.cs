using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<label for='languages'>Choose a language: </label>" +
                "<select name='value' id='languages'>" +
                    "<option value='English' selected>English</option>" +
                    "<option value='French'>French</option>" +
                    "<option value='German'>German</option>" +
                    "<option value='Italian'>Italian</option>" +
                    "<option value='Portuguese'>Portuguese</option>" +
                    "<option value='Spanish'>Spanish</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            
            return Content(html, "text/html");
        }

        //CreateMEssage
        [Route("/Hello")]
        [HttpPost]
        public IActionResult CreateMessage(string name, string value)
        {
            string message = "";
            if(value == "English")
            {
                message = "Hello";
            }
            else if(value == "French")
            {
                message = "Bonjour";
            }
            else if (value == "German")
            {
                message = "Guten Tag";
            }
            else if (value == "Italian")
            {
                message = "Ciao";
            }
            else if (value == "Portuguese")
            {
                message = "Olà";
            }
            else if (value == "Spanish")
            {
                message = "Hola";
            }
            return Content(string.Format("<h1>{0} {1}<h1>", message, name), "text/html");
        }


        //// /Hello
        //[Route("/Hello")]
        //[HttpPost]
        //public IActionResult Display(string name = "World")
        //{
        //    return Content(string.Format("<h1>Hello {0}<h1>", name), "text/html");
        //}

        //// Handle requests /Hello/andy (url segment)
        //[Route("/Hello/{name}")]
        //public IActionResult Index2(string name)
        //{
        //    return Content(string.Format("<h1>Hello {0}<h1>", name), "text/html");
        //}
        
        //public IActionResult Goodbye()
        //{
        //    return Content("Goodbye");
        //}
    }
}
