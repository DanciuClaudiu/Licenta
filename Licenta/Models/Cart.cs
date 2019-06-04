using System.Collections.Generic;

namespace Licenta.Models
{
    public class Cart
    {

        public int Id { get; set; }

        public User User { get; set; }

        public IEnumerable<Instrument> Instruments { get; set; }
   
    }
}
