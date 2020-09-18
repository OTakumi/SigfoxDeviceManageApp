using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SigfoxDeviceManageApp.Models;

namespace SigfoxDeviceManageApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SigfoxDeviceManageApp.Models.DeviceDataModel> DeviceDataModel { get; set; }
    }
}
