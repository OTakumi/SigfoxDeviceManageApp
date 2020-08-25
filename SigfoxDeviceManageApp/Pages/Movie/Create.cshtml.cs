using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SigfoxDeviceManageApp.Data;
using SigfoxDeviceManageApp.Models;

namespace SigfoxDeviceManageApp.Pages.Movie
{
    public class CreateModel : PageModel
    {
        private readonly SigfoxDeviceManageApp.Data.SigfoxDeviceManageAppContext _context;

        public CreateModel(SigfoxDeviceManageApp.Data.SigfoxDeviceManageAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MovieModel MovieModel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MovieModel.Add(MovieModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
