using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SigfoxDeviceManageApp.Models;

namespace SigfoxDeviceManageApp.Data
{
    public class SigfoxDeviceManageAppContext : DbContext
    {
        public SigfoxDeviceManageAppContext (DbContextOptions<SigfoxDeviceManageAppContext> options)
            : base(options)
        {
        }

        public DbSet<SigfoxDeviceManageApp.Models.MovieModel> MovieModel { get; set; }
    }
}
