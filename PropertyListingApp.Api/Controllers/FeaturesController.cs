using Microsoft.AspNetCore.Mvc;
using PropertyListingApp.Data;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : BaseController<Feature>
    {
        public FeaturesController(PropertyListingAppDbContext context) : base(context)
        {
        }
    }
}
