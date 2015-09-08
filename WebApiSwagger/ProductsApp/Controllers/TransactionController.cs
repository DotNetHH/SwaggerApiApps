using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class TransactionController : ApiController
    {
        // GET: api/transaction
        /// <summary>
        /// Get a transaction by its Id
        /// </summary>
        /// <remarks>Get a transaction</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Transaction</returns>
        [HttpGet]
        [Route("api/transaction/{id}")]
        [ResponseType(typeof(Transaction))]
        public async Task<IHttpActionResult> GetTransaction(int id)
        {
            return Ok(new Transaction() { Id = id });
        }

        // PUT: api/transaction
        /// <summary>
        /// Add a transaction
        /// </summary>
        /// <remarks>Add a transaction</remarks>
        /// <param name="transaction">Transaction transaction</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Transaction</returns>
        [HttpPut]
        [Route("api/transaction")]
        [ResponseType(typeof(Transaction))]
        public async Task<IHttpActionResult> AddTransaction([FromBody] Transaction transaction)
        {
            transaction.Id = new Random().Next(5, 1000);
            return Ok(transaction);
        }

        // PATCH: api/transaction
        /// <summary>
        /// Update a transaction by its Id
        /// </summary>
        /// <remarks>Update a transaction</remarks>
        /// <param name="id">int id</param>
        /// <param name="transaction">Transaction transaction</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/transaction/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateTransaction(int id, [FromBody] Transaction transaction)
        {
            return Ok();
        }

        // DELETE: api/transaction
        /// <summary>
        /// Delete a transaction by its Id
        /// </summary>
        /// <remarks>Delete a transaction</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/transaction/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteTransaction(int id)
        {
            return Ok();
        }
    }
}
