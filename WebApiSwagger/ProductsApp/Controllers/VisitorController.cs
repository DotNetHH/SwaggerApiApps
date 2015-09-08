using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class VisitorController : ApiController
    {
        // GET: api/visitors
        /// <summary>
        /// Get a visitors by its Id
        /// </summary>
        /// <remarks>Get a visitors</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Visitor</returns>
        [HttpGet]
        [Route("api/visitors/{id}")]
        [ResponseType(typeof(Visitor))]
        public async Task<IHttpActionResult> GetVisitor(int id)
        {
            return Ok(new Visitor() { Id = id });
        }

        // PUT: api/visitors
        /// <summary>
        /// Add a visitors
        /// </summary>
        /// <remarks>Add a visitors</remarks>
        /// <param name="visitors">Visitor visitors</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Visitor</returns>
        [HttpPut]
        [Route("api/visitors")]
        [ResponseType(typeof(Visitor))]
        public async Task<IHttpActionResult> AddVisitor([FromBody] Visitor visitors)
        {
            visitors.Id = new Random().Next(5, 1000);
            return Ok(visitors);
        }

        // PATCH: api/visitors
        /// <summary>
        /// Update a visitors by its Id
        /// </summary>
        /// <remarks>Update a visitors</remarks>
        /// <param name="id">int id</param>
        /// <param name="visitors">Visitor visitors</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/visitors/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateVisitor(int id, [FromBody] Visitor visitors)
        {
            return Ok();
        }

        // DELETE: api/visitors
        /// <summary>
        /// Delete a visitors by its Id
        /// </summary>
        /// <remarks>Delete a visitors</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/visitors/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteVisitor(int id)
        {
            return Ok();
        }
    }
}
