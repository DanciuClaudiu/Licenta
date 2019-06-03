using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Licenta.Models;

namespace ProiectColectiv.Controllers
{
    public class UserPageController : Controller
    {
        private readonly LicentaContext _context;

        public UserPageController(LicentaContext context)
        {
            _context = context;
        }
        // GET
        public ActionResult UserPage(User user)
        {
            return View("~/Views/Home/UserPage.cshtml");
        }
        [HttpPost]
        public void BookingNormal(int? id)
        {
           
        }

    }
}