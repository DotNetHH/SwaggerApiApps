using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class SatisfactionController : ApiController
    {
        // GET: api/satisfaction
        /// <summary>
        /// Get a satisfaction by its Id
        /// </summary>
        /// <remarks>Get a satisfaction</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Satisfaction</returns>
        [HttpGet]
        [Route("api/satisfaction/{id}")]
        [ResponseType(typeof(Satisfaction))]
        public async Task<IHttpActionResult> GetSatisfaction(int id)
        {
            return Ok(new Satisfaction() { Id = id });
        }

        // PUT: api/satisfaction
        /// <summary>
        /// Add a satisfaction
        /// </summary>
        /// <remarks>Add a satisfaction</remarks>
        /// <param name="satisfaction">Satisfaction satisfaction</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Satisfaction</returns>
        [HttpPut]
        [Route("api/satisfaction")]
        [ResponseType(typeof(Satisfaction))]
        public async Task<IHttpActionResult> AddSatisfaction([FromBody] Satisfaction satisfaction)
        {
            satisfaction.Id = new Random().Next(5, 1000);
            return Ok(satisfaction);
        }

        // PATCH: api/satisfaction
        /// <summary>
        /// Update a satisfaction by its Id
        /// </summary>
        /// <remarks>Update a satisfaction</remarks>
        /// <param name="id">int id</param>
        /// <param name="satisfaction">Satisfaction satisfaction</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/satisfaction/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateSatisfaction(int id, [FromBody] Satisfaction satisfaction)
        {
            return Ok();
        }

        // DELETE: api/satisfaction
        /// <summary>
        /// Delete a satisfaction by its Id
        /// </summary>
        /// <remarks>Delete a satisfaction</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/satisfaction/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteSatisfaction(int id)
        {
            return Ok();
        }
    }
}
