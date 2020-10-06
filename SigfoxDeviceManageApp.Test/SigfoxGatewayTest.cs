using SigfoxDeviceManageApp.Pages.Sigfox;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SigfoxDeviceManageApp.Tests
{
    public class SigfoxGatewayTest
    {
        /// <summary>
        /// Check that there is an API response.
        /// </summary>
        [Fact]
        public void MessageAPIResponseCheck()
        {
            Assert.NotNull(DeviceMessagesModel.GetMessage());
        }
    }
}
