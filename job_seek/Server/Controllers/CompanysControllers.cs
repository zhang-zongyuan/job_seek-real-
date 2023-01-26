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
using job_seek.Server.IRepository;

namespace job_seek.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanysController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public CompanysController(ApplicationDbContext context)
        public CompanysController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }

        // GET: api/Companys
        [HttpGet]

        //Refactored
        //public async TaskActionResult<IEnumerable<Company>>>GetCompanys()
        public async Task<IActionResult> GetCompanys()
        {
            //Refactored
            //return await _context.Companys.TolistAsync
            var Companys = await _unitOfWork.Companys.GetAll();
            return Ok(Companys);
        }

        // GET: api/Companys/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Company>> GetCompany(int id)
        public async Task<ActionResult> GetCompany(int id)
        {
            //Refactored
            //var Company = await _context.Companys.FindAsync(id);
            var Company = await _unitOfWork.Companys.Get(q => q.Id == id);

            if (Company == null)
            {
                return NotFound();
            }

            return Ok(Company);
        }

        // PUT: api/Companys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company Company)
        {
            if (id != Company.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(Company).State = EntityState.Modified;
            _unitOfWork.Companys.Update(Company);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!CompanyExists(id))
                if (!await CompanyExists(id))
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

        // POST: api/Companys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company Company)
        {
            //Refactored
            //_context.Companys.Add(Company);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Companys.Insert(Company);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCompany", new { id = Company.Id }, Company);
        }

        // DELETE: api/Companys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            //Refactored
            //var Company = await _context.Companys.FindAsync(id);
            var Company = await _unitOfWork.Companys.Get(q => q.Id == id);
            if (Company == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Companys.Remove(Company);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Companys.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CompanyExists(int id)
        private async Task<bool> CompanyExists(int id)
        {
            //Refactored
            //return _context.Companys.Any(e => e.Id == id);
            var Company = await _unitOfWork.Companys.Get(q => q.Id == id);
            return Company != null;
        }
    }
}
