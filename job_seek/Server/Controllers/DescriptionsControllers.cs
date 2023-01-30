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
using System.Drawing;

namespace job_seek.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescriptionsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public DescriptionsController(ApplicationDbContext context)
        public DescriptionsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Descriptions
        [HttpGet]

        //Refactored
        //public async TaskActionResult<IEnumerable<Description>>>GetDescriptions()
        public async Task<IActionResult> GetDescriptions()
        {
            //To be deleted or comment after testing the Global Error Handling
           // return NotFound();
            //Refactored
            //return await _context.Descriptions.TolistAsync
            var Descriptions = await _unitOfWork.Descriptions.GetAll();
            return Ok(Descriptions);
        }

        // GET: api/Descriptions/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Description>> GetDescription(int id)
        public async Task<ActionResult> GetDescription(int id)
        {
            //Refactored
            //var Description = await _context.Descriptions.FindAsync(id);
            var Description = await _unitOfWork.Descriptions.Get(q => q.Id == id);

            if (Description == null)
            {
                return NotFound();
            }

            return Ok(Description);
        }

        // PUT: api/Descriptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDescription(int id, Description Description)
        {
            if (id != Description.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(Description).State = EntityState.Modified;
            _unitOfWork.Descriptions.Update(Description);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!DescriptionExists(id))
                if (!await DescriptionExists(id))
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

        // POST: api/Descriptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Description>> PostDescription(Description Description)
        {
            //Refactored
            //_context.Descriptions.Add(Description);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Descriptions.Insert(Description);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetDescription", new { id = Description.Id }, Description);
        }

        // DELETE: api/Descriptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDescription(int id)
        {
            //Refactored
            //var Description = await _context.Descriptions.FindAsync(id);
            var Description = await _unitOfWork.Descriptions.Get(q => q.Id == id);
            if (Description == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Descriptions.Remove(Description);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Descriptions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool DescriptionExists(int id)
        private async Task<bool> DescriptionExists(int id)
        {
            //Refactored
            //return _context.Descriptions.Any(e => e.Id == id);
            var Description = await _unitOfWork.Descriptions.Get(q => q.Id == id);
            return Description != null;
        }
    }
}
