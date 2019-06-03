using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Licenta.Models;
using System.Threading.Tasks;

namespace ProiectColectiv.Controllers
{
    public class LoginController : Controller
    {
        private readonly LicentaContext _context;

        public LoginController(LicentaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Login()
        {
            var user = new User();
            return View("~/Views/Home/Login.cshtml", user);
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Id, Email, Password, Name")] User user)
        {
            var users = await _context.User.FirstOrDefaultAsync(m => m.Email == user.Email);
            if (users != null && users.isAdmin == true && user.Email.Equals(users.Email) && user.Password.Equals(users.Password))
            {
                return RedirectToAction("AdminPage", "AdminPage", users);
            }
            if (users != null && user.isAdmin == false && user.Email.Equals(users.Email) && user.Password.Equals(users.Password))
            {
                return RedirectToAction("UserPage", "UserPage", users);
            }

            return View("~/Views/Home/LoginError.cshtml");
        }

        public ActionResult SignOut()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}