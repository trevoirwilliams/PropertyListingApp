using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyListingApp.Data;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyListingsController : BaseController<PropertyListing>
    {
        public PropertyListingsController(PropertyListingAppDbContext context) : base(context)
        {
        }

        [HttpGet("propertyListingType/{propertyListingTypeId}")]
        public async Task<ActionResult<List<PropertyListing>>> GetPropertiesByTypeId(int propertyListingTypeId)
        {
            var properties = await _context.PropertyListings.Where(property => property.PropertyTypeId == propertyListingTypeId)
                .ToListAsync();

            return Ok(properties);
        }
         
        [HttpGet("propertiesByUser/{userId}")]
        public async Task<ActionResult<List<PropertyListing>>> GetPropertiesByUserId(string userId)
        {
            var properties = await _context.PropertyListings.Where(q => q.ApiUserId.Equals(userId)).ToListAsync();
            return Ok(properties);
        }

        [HttpGet("{id}")]
        public async override Task<ActionResult<PropertyListing>> Get(int id)
        {
            var property = await _context.PropertyListings
                .Include(q => q.Currency)
                .Include(q => q.City)
                .Include(q => q.ContractType)
                .Include(q => q.PropertyType)
                .Include(q => q.PropertyFeatures).ThenInclude(q => q.Feature)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (property == null) return NotFound();
            
            return Ok(property);
        }

    }
}
