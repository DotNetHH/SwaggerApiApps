using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class StatisticController : ApiController
    {
        // GET: api/statistic
        /// <summary>
        /// Get a statistic by its Id
        /// </summary>
        /// <remarks>Get a statistic</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Statistic</returns>
        [HttpGet]
        [Route("api/statistic/{id}")]
        [ResponseType(typeof(Statistic))]
        public async Task<IHttpActionResult> GetStatistic(int id)
        {
            return Ok(new Statistic() { Id = id });
        }

        // PUT: api/statistic
        /// <summary>
        /// Add a statistic
        /// </summary>
        /// <remarks>Add a statistic</remarks>
        /// <param name="statistic">Statistic statistic</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Statistic</returns>
        [HttpPut]
        [Route("api/statistic")]
        [ResponseType(typeof(Statistic))]
        public async Task<IHttpActionResult> AddStatistic([FromBody] Statistic statistic)
        {
            statistic.Id = new Random().Next(5, 1000);
            return Ok(statistic);
        }

        // PATCH: api/statistic
        /// <summary>
        /// Update a statistic by its Id
        /// </summary>
        /// <remarks>Update a statistic</remarks>
        /// <param name="id">int id</param>
        /// <param name="statistic">Statistic statistic</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/statistic/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateStatistic(int id, [FromBody] Statistic statistic)
        {
            return Ok();
        }

        // DELETE: api/statistic
        /// <summary>
        /// Delete a statistic by its Id
        /// </summary>
        /// <remarks>Delete a statistic</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/statistic/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteStatistic(int id)
        {
            return Ok();
        }
    }
}
