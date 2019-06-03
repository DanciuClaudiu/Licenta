using Licenta.Models;
using System.Collections.Generic;

namespace Licenta.ViewModels
{
    public class InstrumentsViewModel
    {
        public User User { get; set; }
        public IEnumerable<Instrument> Instruments { get; set; }
    }
}
