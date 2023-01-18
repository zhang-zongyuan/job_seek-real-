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
    public class AppsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public AppsController(ApplicationDbContext context)
        public AppsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Apps
        [HttpGet]

        //Refactored
        //public async TaskActionResult<IEnumerable<App>>>GetApps()
        public async Task<IActionResult> GetApps()
        {
            return NotFound();
            //Refactored
            //return await _context.Apps.TolistAsync
            var Apps = await _unitOfWork.Apps.GetAll();
            return Ok(Apps);
        }

        // GET: api/Apps/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<App>> GetApp(int id)
        public async Task<ActionResult> GetApp(int id)
        {
            //Refactored
            //var App = await _context.Apps.FindAsync(id);
            var App = await _unitOfWork.Apps.Get(q => q.Id == id);

            if (App == null)
            {
                return NotFound();
            }

            return Ok(App);
        }

        // PUT: api/Apps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApp(int id, App App)
        {
            if (id != App.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(App).State = EntityState.Modified;
            _unitOfWork.Apps.Update(App);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!AppExists(id))
                if (!await AppExists(id))
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

        // POST: api/Apps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<App>> PostApp(App App)
        {
            //Refactored
            //_context.Apps.Add(App);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Apps.Insert(App);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetApp", new { id = App.Id }, App);
        }

        // DELETE: api/Apps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApp(int id)
        {
            //Refactored
            //var App = await _context.Apps.FindAsync(id);
            var App = await _unitOfWork.Apps.Get(q => q.Id == id);
            if (App == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Apps.Remove(App);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Apps.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool AppExists(int id)
        private async Task<bool> AppExists(int id)
        {
            //Refactored
            //return _context.Apps.Any(e => e.Id == id);
            var App = await _unitOfWork.Apps.Get(q => q.Id == id);
            return App != null;
        }
    }
}
