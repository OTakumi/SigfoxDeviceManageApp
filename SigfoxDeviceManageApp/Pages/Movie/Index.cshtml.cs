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
    public class IndexModel : PageModel
    {
        private readonly SigfoxDeviceManageApp.Data.SigfoxDeviceManageAppContext _context;

        public IndexModel(SigfoxDeviceManageApp.Data.SigfoxDeviceManageAppContext context)
        {
            _context = context;
        }

        public IList<MovieModel> MovieModel { get;set; }

        public async Task OnGetAsync()
        {
            MovieModel = await _context.MovieModel.ToListAsync();
        }
    }
}
