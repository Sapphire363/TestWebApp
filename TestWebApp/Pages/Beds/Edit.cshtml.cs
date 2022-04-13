#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Data;
using TestWebApp.Models;

namespace TestWebApp.Pages.Beds
{
    public class EditModel : PageModel
    {
        private readonly TestWebApp.Data.TestWebAppContext _context;

        public EditModel(TestWebApp.Data.TestWebAppContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Bed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BedExists(Bed.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BedExists(int id)
        {
            return _context.Bed.Any(e => e.ID == id);
        }
    }
}
