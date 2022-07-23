using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyListingApp.Api.DTOs.City;
using PropertyListingApp.Data;
using PropertyListingApp.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropertyListingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly PropertyListingAppDbContext _context;

        public CitiesController(PropertyListingAppDbContext context)
        {
            _context = context;
        }

        // GET: api/<CitiesController>
        [HttpGet]
        public async Task<ActionResult<List<City>>> Get()
        {
            return Ok(await _context.Cities.ToListAsync());
        }

        // GET api/<CitiesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> Get(int id)
        {
            City? city = await _context.Cities.FindAsync(id);
            if(city == null) return NotFound();

            return Ok(city);
        }

        // POST api/<CitiesController>
        [HttpPost]
        public async Task<ActionResult<City>> Post([FromBody] CreateCityDto cityDto)
        {
            try
            {
                var city = new City
                {
                    Name = cityDto.Name
                };

                await _context.AddAsync(city);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(Post), city);
            }
            catch (Exception ex)
            {
                return BadRequest("Please check your city data and try again");
            }
        }

        // PUT api/<CitiesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] City city)
        {
            try
            {
                if(id != city.Id)
                {
                    throw new Exception("Bad Request Data");
                }

                _context.Update(city);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest("Please check your city data and try again");
            }
        }

        // DELETE api/<CitiesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                City? city = await _context.Cities.FindAsync(id);
                if (city == null) return NotFound();

                _context.Remove(city);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("Please check your city data and try again");
            }
        }
    }
}
