using Microsoft.AspNetCore.Mvc;

namespace prjFinanceTime.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
