using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SigfoxDeviceManageApp.Data;
using SigfoxDeviceManageApp.Models;

namespace SigfoxDeviceManageApp.Pages.Sigfox
{
    public class MessageListModel : PageModel
    {
        private readonly SigfoxDeviceManageApp.Data.ApplicationDbContext _context;

        public MessageListModel(SigfoxDeviceManageApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<DeviceDataModel> DeviceDataModel { get;set; }

        public async Task OnGetAsync()
        {
            DeviceDataModel = await _context.DeviceDataModel.ToListAsync();
        }
    }
}
