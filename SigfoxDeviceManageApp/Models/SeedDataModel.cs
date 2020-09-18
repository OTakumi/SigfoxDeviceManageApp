using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SigfoxDeviceManageApp.Data;

namespace SigfoxDeviceManageApp.Models
{
    public class SeedDataModel
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SigfoxDeviceManageAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<SigfoxDeviceManageAppContext>>()))
            {
                // Look for any movies
            }
        }
    }
}
