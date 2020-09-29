using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SigfoxDeviceManageApp.Pages
{
    public class DeviceMessagesModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
