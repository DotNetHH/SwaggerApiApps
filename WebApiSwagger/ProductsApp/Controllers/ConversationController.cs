using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class ConversationController : ApiController
    {
        // GET: api/conversations
        /// <summary>
        /// Get a conversations by its Id
        /// </summary>
        /// <remarks>Get a conversations</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Conversation</returns>
        [HttpGet]
        [Route("api/conversations/{id}")]
        [ResponseType(typeof(Conversation))]
        public async Task<IHttpActionResult> GetConversation(int id)
        {
            return Ok(new Conversation() { Id = id });
        }

        // PUT: api/conversations
        /// <summary>
        /// Add a conversations
        /// </summary>
        /// <remarks>Add a conversations</remarks>
        /// <param name="conversations">Conversation conversations</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Conversation</returns>
        [HttpPut]
        [Route("api/conversations")]
        [ResponseType(typeof(Conversation))]
        public async Task<IHttpActionResult> AddConversation([FromBody] Conversation conversations)
        {
            conversations.Id = new Random().Next(5, 1000);
            return Ok(conversations);
        }

        // PATCH: api/conversations
        /// <summary>
        /// Update a conversations by its Id
        /// </summary>
        /// <remarks>Update a conversations</remarks>
        /// <param name="id">int id</param>
        /// <param name="conversations">Conversation conversations</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/conversations/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateConversation(int id, [FromBody] Conversation conversations)
        {
            return Ok();
        }

        // DELETE: api/conversations
        /// <summary>
        /// Delete a conversations by its Id
        /// </summary>
        /// <remarks>Delete a conversations</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/conversations/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteConversation(int id)
        {
            return Ok();
        }
    }
}
