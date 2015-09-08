using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class OperatorController : ApiController
    {
        // GET: api/operator
        /// <summary>
        /// Get a operator by its Id
        /// </summary>
        /// <remarks>Get a operator</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Operator</returns>
        [HttpGet]
        [Route("api/operator/{id}")]
        [ResponseType(typeof(Operator))]
        public async Task<IHttpActionResult> GetOperator(int id)
        {
            return Ok(new Operator() { Id = id });
        }

        // PUT: api/operator
        /// <summary>
        /// Add a operator
        /// </summary>
        /// <remarks>Add a operator</remarks>
        /// <param name="operator">Operator operator</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Operator</returns>
        [HttpPut]
        [Route("api/operator")]
        [ResponseType(typeof(Operator))]
        public async Task<IHttpActionResult> AddOperator([FromBody] Operator @operator)
        {
            @operator.Id = new Random().Next(5, 1000);
            return Ok(@operator);
        }

        // PATCH: api/operator
        /// <summary>
        /// Update a operator by its Id
        /// </summary>
        /// <remarks>Update a operator</remarks>
        /// <param name="id">int id</param>
        /// <param name="operator">Operator operator</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/operator/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateOperator(int id, [FromBody] Operator @operator)
        {
            return Ok();
        }

        // DELETE: api/operator
        /// <summary>
        /// Delete a operator by its Id
        /// </summary>
        /// <remarks>Delete a operator</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/operator/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteOperator(int id)
        {
            return Ok();
        }
    }
}
