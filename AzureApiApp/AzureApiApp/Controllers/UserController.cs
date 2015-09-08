using AzureApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AzureApiApp.Controllers
{
    public class UserController : ApiController
    {
        // Get: api/Users
        /// <summary>
        /// Get all Users
        /// </summary>
        /// <remarks>Get all Users for the Email service</remarks>
        /// <response code="200">Ok</response>
        /// <response code="404">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>IEnumerable&lt;User&gt;</returns>
        [Route("api/Users")]
        [HttpGet]
        [ResponseType(typeof(IEnumerable<User>))]
        public async Task<IHttpActionResult> GetAllUsers()
        {
            try
            {
                return Ok(UserStore.GetAllUsers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/User
        /// <summary>
        /// Signup a User
        /// </summary>
        /// <param name="user">User user</param>
        /// <remarks>Sign up a User for the Email service</remarks>
        /// <response code="200">Ok</response>
        /// <response code="404">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [Route("api/User")]
        [HttpPut]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> SignupUser(User user)
        {
            try
            {
                UserStore.Add(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // PATCH: api/User
        /// <summary>
        /// Update a User
        /// </summary>
        /// <param name="user">User user</param>
        /// <remarks>Update a User for the Email service</remarks>
        /// <response code="200">Ok</response>
        /// <response code="404">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [Route("api/User")]
        [HttpDelete]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateUser(User user)
        {
            try
            {
                UserStore.Update(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // DELETE: api/User
        /// <summary>
        /// Remove a User
        /// </summary>
        /// <param name="user">User user</param>
        /// <remarks>Remove a User for the Email service</remarks>
        /// <response code="200">Ok</response>
        /// <response code="404">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [Route("api/User")]
        [HttpDelete]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteUser(User user)
        {
            try
            {
                UserStore.Remove(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
