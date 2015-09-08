using ProductsApp.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProductsApp.Controllers
{
    public class SkillController : ApiController
    {
        // GET: api/skill
        /// <summary>
        /// Get a skill by its Id
        /// </summary>
        /// <remarks>Get a skill</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Skill</returns>
        [HttpGet]
        [Route("api/skill/{id}")]
        [ResponseType(typeof(Skill))]
        public async Task<IHttpActionResult> GetSkill(int id)
        {
            return Ok(new Skill() { Id = id });
        }

        // PUT: api/skill
        /// <summary>
        /// Add a skill
        /// </summary>
        /// <remarks>Add a skill</remarks>
        /// <param name="skill">Skill skill</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Skill</returns>
        [HttpPut]
        [Route("api/skill")]
        [ResponseType(typeof(Skill))]
        public async Task<IHttpActionResult> AddSkill([FromBody] Skill skill)
        {
            skill.Id = new Random().Next(5, 1000);
            return Ok(skill);
        }

        // PATCH: api/skill
        /// <summary>
        /// Update a skill by its Id
        /// </summary>
        /// <remarks>Update a skill</remarks>
        /// <param name="id">int id</param>
        /// <param name="skill">Skill skill</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpPatch]
        [Route("api/skill/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> UpdateSkill(int id, [FromBody] Skill skill)
        {
            return Ok();
        }

        // DELETE: api/skill
        /// <summary>
        /// Delete a skill by its Id
        /// </summary>
        /// <remarks>Delete a skill</remarks>
        /// <param name="id">int id</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>void</returns>
        [HttpDelete]
        [Route("api/skill/{id}")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> DeleteSkill(int id)
        {
            return Ok();
        }
    }
}
