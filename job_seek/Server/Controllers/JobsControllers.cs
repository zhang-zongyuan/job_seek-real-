using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_seek.Server.Data;
using job_seek.Shared.Domain;
using job_seek.Server.IRepository;

namespace job_seek.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public JobsController(ApplicationDbContext context)
        public JobsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Jobs
        [HttpGet]

        //Refactored
        //public async TaskActionResult<IEnumerable<Job>>>GetJobs()
        public async Task<IActionResult> GetJobs()
        {
            //Refactored
            //return await _context.Jobs.TolistAsync
            var Jobs = await _unitOfWork.Jobs.GetAll(includes: q => q.Include(x => x.Make).Include(x => x.Company).Include(x => x.Description));
            return Ok(Jobs);
        }

        // GET: api/Jobs/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Job>> GetJob(int id)
        public async Task<ActionResult> GetJob(int id)
        {
            //Refactored
            //var Job = await _context.Jobs.FindAsync(id);
            var Job = await _unitOfWork.Jobs.Get(q => q.Id == id);

            if (Job == null)
            {
                return NotFound();
            }

            return Ok(Job);
        }

        // PUT: api/Jobs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJob(int id, Job Job)
        {
            if (id != Job.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(Job).State = EntityState.Modified;
            _unitOfWork.Jobs.Update(Job);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!JobExists(id))
                if (!await JobExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Jobs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Job>> PostJob(Job Job)
        {
            //Refactored
            //_context.Jobs.Add(Job);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Jobs.Insert(Job);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetJob", new { id = Job.Id }, Job);
        }

        // DELETE: api/Jobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            //Refactored
            //var Job = await _context.Jobs.FindAsync(id);
            var Job = await _unitOfWork.Jobs.Get(q => q.Id == id);
            if (Job == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Jobs.Remove(Job);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Jobs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool JobExists(int id)
        private async Task<bool> JobExists(int id)
        {
            //Refactored
            //return _context.Jobs.Any(e => e.Id == id);
            var Job = await _unitOfWork.Jobs.Get(q => q.Id == id);
            return Job != null;
        }
    }
}