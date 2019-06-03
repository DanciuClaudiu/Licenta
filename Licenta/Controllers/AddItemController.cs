using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Licenta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Licenta.Controllers
{
    public class AddItemController : Controller
    {
        private readonly LicentaContext _context;

        public AddItemController(LicentaContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult AddItem()
        {
            var instrument = new Instrument();
            return View("~/Views/Home/AddItem.cshtml", instrument);
        }

        [HttpPost]
        public async Task<ActionResult> AddItem([Bind("Id, Name, Price, Quantity, Type")] Instrument instrument)
        {
            var instruments = await _context.Instrument.FirstOrDefaultAsync(m => m.Name == instrument.Name);
            if (instruments == null || !instrument.Name.Equals(instruments.Name))
            {
                _context.Add(instrument);
                await _context.SaveChangesAsync();

                return View("~/Views/Home/AddItemSuccess.cshtml");
            }
            return View("~/Views/Home/AddItemError.cshtml");


        }
    }
}
