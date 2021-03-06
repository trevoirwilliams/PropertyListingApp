using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyListingApp.Data;
using PropertyListingApp.Data.Models;

namespace PropertyListingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractTypesController : BaseController<ContractType>
    {
        public ContractTypesController(PropertyListingAppDbContext context) : base(context)
        {
        }
    }
}
