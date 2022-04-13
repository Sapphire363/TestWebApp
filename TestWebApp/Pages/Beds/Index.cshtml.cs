#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Data;
using TestWebApp.Models;

namespace TestWebApp.Pages.Beds
{
    public class IndexModel : PageModel
    {
        private readonly TestWebApp.Data.TestWebAppContext _context;

        public IndexModel(TestWebApp.Data.TestWebAppContext context)
        {
            _context = context;
        }

        public IList<Bed> Bed { get;set; }

        public async Task OnGetAsync()
        {
            Bed = await _context.Bed.ToListAsync();
        }
    }
}
