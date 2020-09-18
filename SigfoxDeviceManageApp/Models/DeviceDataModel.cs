using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SigfoxDeviceManageApp.Models
{
    public class DeviceDataModel
    {
        public int Id { get; set; }
        public Guid deviceId { get; set; }
        public string deviceName { get; set; }
        public DateTime resisteDateTime { get; set; }
        public double temperature { get; set; }
        public int humidity { get; set; }
    }
}
