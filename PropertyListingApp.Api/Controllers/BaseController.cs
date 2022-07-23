using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyListingApp.Data;
using PropertyListingApp.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PropertyListingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity> : ControllerBase where TEntity : BaseEntity<int>
    {
        protected readonly PropertyListingAppDbContext _context;
        protected DbSet<TEntity> _dbSet { get; set; }

        public BaseController(PropertyListingAppDbContext context)
        {
            this._context = context;
            _dbSet = _context.Set<TEntity>();
        }

        [HttpGet]
        public virtual async Task<ActionResult<List<TEntity>>> Get()
        {
            return Ok(await _dbSet.ToListAsync());
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> Get(int id)
        {
            TEntity? entity = await _dbSet.FindAsync(id);
            if (entity == null) return NotFound();
            
            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<ActionResult<TEntity>> Post([FromBody] TEntity entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(Post), entity);
            }
            catch (Exception ex)
            {
                return BadRequest("Please check your data and try again");
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Put(int id, [FromBody] TEntity entity)
        {
            try
            {
                if (id != entity.Id)
                {
                    throw new Exception("Bad Request Data");
                }

                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest("Please check your data and try again");
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            try
            {
                TEntity? entity = await _dbSet.FindAsync(id);
                if (entity == null) return NotFound();

                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("Please check your data and try again");
            }
        }
    }
}
