using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class TagController : ApiController
    {
        // GET: api/tag
        /// <summary>
        /// Get a tag by its Id
        /// </summary>
        /// <remarks>Get a tag</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Tag</returns>
        [HttpGet]
        [Route("api/tag/{id}")]
        [ResponseType(typeof(Tag))]
        public async Task<IHttpActionResult> GetTag(int id)
        {
            return Ok(new Tag() { Id = id });
        }

        // PUT: api/tag
        /// <summary>
        /// Add a tag
        /// </summary>
        /// <remarks>Add a tag</remarks>
        /// <param name="tag">Tag tag</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Tag</returns>
        [HttpPut]
        [Route("api/tag")]
        [ResponseType(typeof(Tag))]
        public async Task<IHttpActionResult> AddTag([FromBody] Tag tag)
        {
            tag.Id = new Random().Next(5, 1000);
            return Ok(tag);
        }

        // PATCH: api/tag
        /// <summary>
        /// Update a tag by its Id
        /// </summary>
        /// <remarks>Update a tag</remarks>
        /// <param name="id">int id</param>
        /// <param name="tag">Tag tag</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/tag/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateTag(int id, [FromBody] Tag tag)
        {
            return Ok();
        }

        // DELETE: api/tag
        /// <summary>
        /// Delete a tag by its Id
        /// </summary>
        /// <remarks>Delete a tag</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/tag/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteTag(int id)
        {
            return Ok();
        }
    }
}
