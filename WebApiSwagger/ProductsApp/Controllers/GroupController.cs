using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class GroupController : ApiController
    {
        // GET: api/group
        /// <summary>
        /// Get a group by its Id
        /// </summary>
        /// <remarks>Get a group</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Group</returns>
        [HttpGet]
        [Route("api/group/{id}")]
        [ResponseType(typeof(Group))]
        public async Task<IHttpActionResult> GetGroup(int id)
        {
            return Ok(new Group() { Id = id });
        }

        // PUT: api/group
        /// <summary>
        /// Add a group
        /// </summary>
        /// <remarks>Add a group</remarks>
        /// <param name="group">Group group</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Group</returns>
        [HttpPut]
        [Route("api/group")]
        [ResponseType(typeof(Group))]
        public async Task<IHttpActionResult> AddGroup([FromBody] Group group)
        {
            group.Id = new Random().Next(5, 1000);
            return Ok(group);
        }

        // Patch: api/group
        /// <summary>
        /// Update a group by its Id
        /// </summary>
        /// <remarks>Update a group</remarks>
        /// <param name="id">int id</param>
        /// <param name="group">Group group</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/group/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateGroup(int id, [FromBody] Group group)
        {
            return Ok();
        }

        // DELETE: api/group
        /// <summary>
        /// Delete a group by its Id
        /// </summary>
        /// <remarks>Delete a group</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/group/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteGroup(int id)
        {
            return Ok();
        }
    }
}
