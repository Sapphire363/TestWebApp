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
    public class DeleteModel : PageModel
    {
        private readonly TestWebApp.Data.TestWebAppContext _context;

        public DeleteModel(TestWebApp.Data.TestWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bed Bed { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bed = await _context.Bed.FirstOrDefaultAsync(m => m.ID == id);

            if (Bed == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bed = await _context.Bed.FindAsync(id);

            if (Bed != null)
            {
                _context.Bed.Remove(Bed);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
