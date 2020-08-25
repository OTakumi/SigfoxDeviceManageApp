using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SigfoxDeviceManageApp.Data;
using SigfoxDeviceManageApp.Models;

namespace SigfoxDeviceManageApp.Pages.Movie
{
    public class EditModel : PageModel
    {
        private readonly SigfoxDeviceManageApp.Data.SigfoxDeviceManageAppContext _context;

        public EditModel(SigfoxDeviceManageApp.Data.SigfoxDeviceManageAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MovieModel MovieModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieModel = await _context.MovieModel.FirstOrDefaultAsync(m => m.ID == id);

            if (MovieModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MovieModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieModelExists(MovieModel.ID))
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

        private bool MovieModelExists(int id)
        {
            return _context.MovieModel.Any(e => e.ID == id);
        }
    }
}
