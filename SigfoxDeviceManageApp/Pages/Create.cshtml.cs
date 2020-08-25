using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SigfoxDeviceManageApp.Models;

namespace SigfoxDeviceManageApp.Pages
{
    public class CreateModel : PageModel
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Code { get; set; }

        public void OnGet()
        {
        }
    }
}
