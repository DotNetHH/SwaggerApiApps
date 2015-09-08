using AzureApiApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AzureApiApp.Controllers
{
    public class MailController : ApiController
    {
        // POST: api/Mail
        /// <summary>
        /// Send a mail to customer
        /// </summary>
        /// <remarks>Send a mail to customer</remarks>
        /// <response code="200">Ok</response>
        /// <response code="404">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [Route("api/Mail")]
        [HttpPost]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> SendMail([FromBody] string message)
        {
            try
            {
                foreach (var user in UserStore.GetAllUsers())
                {
                    var data = new Dictionary<string, string>
                    {
                        ["to"] = user.Email,
                        ["subject"] = $"New Tweet for #MeetupHH",
                        ["text"] = $"There is a new Tweet hashed with #MeetupHH: {message}",
                    };

                    var result = await SendMessage(data);
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        private async Task<HttpResponseMessage> SendMessage(IDictionary<string,string> data)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.mailgun.net/v3/");
            var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes("api:key-9dc6d41f30467f58888371e7665db547"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
            data.Add("from", "Meetup Hamburg <postmaster@sandboxbc19c2a6b2a3416fb30e19a046d8663a.mailgun.org>");
            var encodedParams = new FormUrlEncodedContent(data);
            var result = await client.PostAsync("sandboxbc19c2a6b2a3416fb30e19a046d8663a.mailgun.org/messages", encodedParams);
            return result;
        }
    }
}
