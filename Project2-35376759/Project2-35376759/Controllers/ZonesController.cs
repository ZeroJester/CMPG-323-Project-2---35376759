using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project2_35376759.Models;

namespace Project2_35376759.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ZonesController : Controller
    {
        private readonly ConnectedOfficeContext _context;

        public ZonesController(ConnectedOfficeContext context)
        {
            _context = context;
        }

        //Return all Zones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Zone>>> GetZone()
        {
            return await _context.Zone.ToListAsync();
        }

        //Return Zone by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Zone>> GetZoneByID(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zone = await _context.Zone.FirstOrDefaultAsync(m => m.ZoneId == id);
           
            if (zone == null)
            {
                return NotFound();
            }

            return zone;
        }

        

        //Edit existing Zone
        [HttpPut]
        [Route("Edit/{id}")]
        public async Task<IActionResult> PutZone(Guid id, Zone zone)
        {
            if (id != zone.ZoneId)
            {
                return BadRequest();
            }

            _context.Entry(zone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!ZoneExists(id))
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

      
        //Add new Zone
        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Zone>> PostZone(Zone zone)
        {
            _context.Zone.Add(zone);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (ZoneExists(zone.ZoneId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetZone", new { id = zone.ZoneId }, zone);
        }

        //Delete existing Zone
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult<Zone>> DeleteZone(Guid id)
        {
            var zone = await _context.Zone.FindAsync(id);

            if(zone == null)
            {
                return NotFound();
            }

            _context.Zone.Remove(zone);
            await _context.SaveChangesAsync();

            return zone;
        }


        //Get Devices that matches ZoneId
        [HttpGet]
        [Route("Device/{id}")]
        public async Task<ActionResult<Device>> GetDeviceByZoneId(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                var dev = await _context.Device.FirstOrDefaultAsync(m => id == m.ZoneId);

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


        //private method to check for existence
        private bool ZoneExists(Guid id)
        {
            return _context.Zone.Any(e => e.ZoneId == id);
        }
    }
}
