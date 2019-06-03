using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Licenta.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Licenta.Controllers
{
    public class AdminPageController : Controller
    {
        private readonly LicentaContext _context;

        public AdminPageController(LicentaContext context)
        {
            _context = context;
        }

        public ActionResult AdminPage(User user)
        {
            return View("~/Views/Home/AdminPage.cshtml", user);
        }
    }
}
