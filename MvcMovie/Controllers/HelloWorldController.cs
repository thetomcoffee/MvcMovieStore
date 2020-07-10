using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        //ver 1:
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        //ver 2:
        public ActionResult Index()
        {
            return View();
        }


        // 
        // GET: /HelloWorld/Welcome/ 

        //ver 1:
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        //}

        //ver 2:
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}