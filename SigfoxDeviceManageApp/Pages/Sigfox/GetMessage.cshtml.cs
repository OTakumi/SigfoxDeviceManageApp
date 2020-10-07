using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SigfoxDeviceManageApp.Pages.Sigfox
{
    public class GetMessageModel : PageModel
    {
        public void OnGet()
        {
        }

        public static async Task<object> GetMessage(string deviceId = "", string loginId = "", string password = "")
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

            string messageData;

            // Get data
            using (var httpClient = new HttpClient())
            {
                // Send a request to the API URI and check the response.
                var response = await httpClient.SendAsync(request);

                // If the authentication is successful, return the value obtained.
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Basic Authorization is Succeeded");
                    return messageData = "Get success";
                }
                else
                {
                    Console.WriteLine("Basic Authorization Error");
                    return null;
                }
            }
        }
    }
}
