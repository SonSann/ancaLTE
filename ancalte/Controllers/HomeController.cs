using Microsoft.AspNetCore.Mvc;

namespace ancalte.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //测试异常处理
            //throw new System.Exception("异常");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
