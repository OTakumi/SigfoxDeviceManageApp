using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SigfoxDeviceManageApp
{
    public class StringOutput
    {
        private int Add(int a, int b)
        {
            return a + b;
        }
        public static string Hello()
        {
            StringOutput stringOutput = new StringOutput();
            string result = string.Format("Hello {0}", stringOutput.Add(1, 3));
            return result;
        }
    }
}
