using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Licenta.Models;
using Licenta.ViewModels;

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

            var instruments = _context.Instrument;
            var model = new InstrumentsViewModel
            {
                User = user,
                Instruments = instruments
            };

            return View("~/Views/Home/AdminPage.cshtml", model);
        }

        [HttpPost]
        public ActionResult DeleteInstrument(Instrument instrumentRequest)
        {
            var instrument = _context.Instrument.First(s => s.Id == instrumentRequest.Id);
            if (instrument == null)
            {
                return BadRequest();
            }

            _context.Remove(instrument);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public ActionResult UpdateInstrument(Instrument instrumentRequest)
        {
            var instrument = _context.Instrument.First(s => s.Id == instrumentRequest.Id);

            if (instrument == null || (string.IsNullOrEmpty(instrumentRequest.Name)))
            {
                return BadRequest();
            }

            if (!string.IsNullOrEmpty(instrumentRequest.Name))
                instrument.Name = instrumentRequest.Name;
            if (instrumentRequest.Price != 0)
                instrument.Price = instrumentRequest.Price;
            if (instrumentRequest.Price != 0)
                instrument.Quantity = instrumentRequest.Quantity;
            if (!string.IsNullOrEmpty(instrumentRequest.Type))
                instrument.Type = instrumentRequest.Type;

            _context.SaveChanges();

            return Ok();
        }

    }
}
