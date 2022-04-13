#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestWebApp.Data;
using TestWebApp.Models;

namespace TestWebApp.Pages.Beds
{
    public class CreateModel : PageModel
    {
        private readonly TestWebApp.Data.TestWebAppContext _context;

        public CreateModel(TestWebApp.Data.TestWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bed Bed { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bed.Add(Bed);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
