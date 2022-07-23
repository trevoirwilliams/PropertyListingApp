using Microsoft.AspNetCore.Mvc;
using PropertyListingApp.Data;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyFeaturesController : BaseController<PropertyFeature>
    {
        public PropertyFeaturesController(PropertyListingAppDbContext context) : base(context)
        {
        }
    }
}
