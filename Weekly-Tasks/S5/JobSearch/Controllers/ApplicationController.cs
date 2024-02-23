using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobSearch.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppContextAlias = JobSearch.Models.AppContext;


namespace JobSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly AppContextAlias _context;

        public ApplicationController(AppContextAlias context)
        {
            _context = context;
        }

        // GET: api/Application
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Application>>> GetApplications()
        {
            return await _context.Applications.ToListAsync();
        }

        // GET: api/Application/5
        [HttpGet("{userId}/{jobId}")]
        public async Task<ActionResult<Application>> GetApplication(int userId, int jobId)
        {
            var application = await _context.Applications.FindAsync(userId, jobId);

            if (application == null)
            {
                return NotFound();
            }

            return application;
        }

        // POST: api/Application
        [HttpPost]
        public async Task<ActionResult<Application>> PostApplication(Application application)
        {
            _context.Applications.Add(application);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetApplication), new { userId = application.UserID, jobId = application.JobID }, application);
        }

        // DELETE: api/Application/5
        [HttpDelete("{userId}/{jobId}")]
        public async Task<IActionResult> DeleteApplication(int userId, int jobId)
        {
            var application = await _context.Applications.FindAsync(userId, jobId);
            if (application == null)
            {
                return NotFound();
            }

            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
