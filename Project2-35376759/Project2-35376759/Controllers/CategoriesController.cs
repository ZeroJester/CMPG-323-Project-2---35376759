using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project2_35376759.Models;

namespace Project2_35376759.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly ConnectedOfficeContext _context;

        public CategoriesController(ConnectedOfficeContext context)
        {
            _context = context;
        }


        //Return all Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
            return await _context.Category.ToListAsync();
        }

        //Return Category by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.CategoryId == id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }



        //Edit existing Category
        [HttpPut]
        [Route("Edit/{id}")]
        public async Task<IActionResult> PutCategory(Guid id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
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


        //Add new Category
        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Category.Add(category);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (CategoryExists(category.CategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCategory", new { id = category.CategoryId }, category);
        }

        //Delete existing Category
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult<Category>> DeleteCategory(Guid id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();

            return category;
        }


        //Get Devices that matches CategoryId
        [HttpGet]
        [Route("Category/{id}")]
        public async Task<ActionResult<Device>> GetDeviceByCategoryId(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                var dev = await _context.Device.FirstOrDefaultAsync(m => id == m.CategoryId);

                if (dev == null)
                {
                    return NotFound();
                }

                return dev;
            }
            catch
            {
                return NotFound();
            }

        }


        //Get number of Zones that matches CategoryId
        [HttpGet]
        [Route("NumberOfZones/{id}")]
        public async Task<int> NumOfZonesPerCategory(Guid id)
        {
            var join = await _context.Device.Join(_context.Zone, firstentity => firstentity.CategoryId, configAccess => configAccess.ZoneId, (val1, val2) => new { FirstEntity = val1, SecondEntity = val2}).ToListAsync();

            var c = _context.Device.Where(m => m.CategoryId == id).Count();

            return c;
        }



        //private method to check for existence
        private bool CategoryExists(Guid id)
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }
    }
}
