using Microsoft.AspNetCore.Mvc;
using PropertyListingApp.Data;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyTypesController : BaseController<PropertyType>
    {
        public PropertyTypesController(PropertyListingAppDbContext context) : base(context)
        {
        }
    }
}
