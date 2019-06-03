using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Licenta.Models;

namespace Licenta.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Licenta.Models.LicentaContext _context;

        public IndexModel(Licenta.Models.LicentaContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
