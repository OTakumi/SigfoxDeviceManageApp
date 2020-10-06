using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SigfoxDeviceManageApp.Controllers
{
    public class SigfoxAPIGatewayController : Controller
    {
        /// <summary>
        /// Getting Data from the Sigfox Cloud API.
        /// </summary>
        /// <returns>return jObject data</returns>
        [HttpGet]
        public static async Task<JObject> GetMessage(string deviceId = "", string loginId = "", string password = "")
        {
            var messageUri = "https://api.sigfox.com/v2/devices/" + deviceId + "/messages";

            // Http request get
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(messageUri)
            };

            // Add Header for Basic Authorization
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                                            Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", loginId, password))));

            JObject messageData;

            // Get data
            using (var httpClient = new HttpClient())
            {
                // Send a request to the API URI and check the response.
                var response = await httpClient.SendAsync(request);

                // If the authentication is successful, return the value obtained.
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Basic Authorization is Succeeded");
                    return messageData = JObject.Parse(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    Console.WriteLine("Basic Authorization Error");
                    return null;
                }
            }
        }

        private static bool RegisterDevice()
        {
            return true;
        }
    }
}
