using System;
using Xunit;
using SigfoxDeviceManageApp;

namespace SigfoxDeviceManageApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HelloTest()
        {
            Assert.Equal("Hello", StringOutput.Hello());
        }
    }
}
