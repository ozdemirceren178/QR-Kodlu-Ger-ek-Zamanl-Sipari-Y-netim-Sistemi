using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {//ana sayfa olucak
            return View();
        }
    }
}
