using Microsoft.AspNetCore.Mvc;
using prjFinanceTime.Data;
using prjFinanceTime.Models.entities;

namespace prjFinanceTime.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext dbContext;

        public UserController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(User userModel)
        {
            await dbContext.Users.AddAsync(userModel);

            await dbContext.SaveChangesAsync();
            return View();
        }
    }
}
