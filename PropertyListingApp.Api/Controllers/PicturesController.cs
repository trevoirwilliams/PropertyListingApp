using Microsoft.AspNetCore.Mvc;
using PropertyListingApp.Data;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturesController : BaseController<Picture>
    {
        public PicturesController(PropertyListingAppDbContext context) : base(context)
        {
        }
    }
}
