using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigfoxDeviceManageApp.Models
{
    public class DeviceDataModel
    {
        private Guid deviceId { get; set; }
        public string deviceName { get; set; }
        public DateTime resisteDateTime { get; set; }
        public double temperature { get; set; }
        public int humidity { get; set; }
    }
}
