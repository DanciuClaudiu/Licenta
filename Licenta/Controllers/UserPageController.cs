using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Licenta.Models;

namespace ProiectColectiv.Controllers
{
    public class UserMapController : Controller
    {
        private readonly LicentaContext _context;

        public UserMapController(LicentaContext context)
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