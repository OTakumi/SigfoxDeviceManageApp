using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SigfoxDeviceManageApp.Data;
using SigfoxDeviceManageApp.Models;

namespace SigfoxDeviceManageApp.Pages.Movie
{
    public class DetailsModel : PageModel
    {
        private readonly SigfoxDeviceManageApp.Data.SigfoxDeviceManageAppContext _context;

        public DetailsModel(SigfoxDeviceManageApp.Data.SigfoxDeviceManageAppContext context)
        {
            _context = context;
        }

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
    }
}
