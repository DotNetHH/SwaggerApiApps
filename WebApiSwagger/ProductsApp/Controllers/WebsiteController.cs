using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class WebsiteController : ApiController
    {
        // GET: api/website
        /// <summary>
        /// Get a Website by its Id
        /// </summary>
        /// <remarks>Get a website</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Website</returns>
        [HttpGet]
        [Route("api/website/{id}")]
        [ResponseType(typeof(Website))]
        public async Task<IHttpActionResult> GetWebsite(int id)
        {
            return Ok(new Website() { Id = id });
        }

        // PUT: api/website
        /// <summary>
        /// Add a Website
        /// </summary>
        /// <remarks>Add a website</remarks>
        /// <param name="website">Website website</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Website</returns>
        [HttpPut]
        [Route("api/website")]
        [ResponseType(typeof(Website))]
        public async Task<IHttpActionResult> AddWebsite([FromBody] Website website)
        {
            website.Id = new Random().Next(5, 1000);
            return Ok(website);
        }

        // PATCH: api/website
        /// <summary>
        /// Update a Website by its Id
        /// </summary>
        /// <remarks>Update a website</remarks>
        /// <param name="id">int id</param>
        /// <param name="website">Website website</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/website/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateWebsite(int id, [FromBody] Website website)
        {
            return Ok();
        }

        // DELETE: api/website
        /// <summary>
        /// Delete a Website by its Id
        /// </summary>
        /// <remarks>Delete a website</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/website/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteWebsite(int id)
        {
            return Ok();
        }
    }
}
