using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Licenta.Models;
using Licenta.ViewModels;

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
            var instruments = _context.Instrument;
            var model = new InstrumentsViewModel
            {
                User = user,
                Instruments = instruments
            };

            return View("~/Views/Home/UserPage.cshtml", model);
        }
 

    }
}