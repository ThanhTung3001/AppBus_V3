using System.Threading.Tasks;
using Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.DbEntities;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseApiController<TEntity> : ControllerBase where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _context;

    public BaseApiController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("Gets")]
    public async Task<IActionResult> Gets()
    {
        var entity = _context.Set<TEntity>();
        return Ok(await entity.ToListAsync());
    }

    [HttpPost]
    [Route("Create")]
    public async Task<IActionResult> Create(TEntity model)
    {
        try
        {
          model.Id =((short)model.Id);
            var entity = await _context.Set<TEntity>().AddAsync(model);
            _context.SaveChanges();
            return Ok(
              new
              {
                  message = $"Create {typeof(TEntity)} sucesss",
                  data = entity,
                  code = 201
              }
            );
        }
        catch (System.Exception ex)
        {

            return Ok(
                 new
                 {
                     message = $"Create {typeof(TEntity)} fail: {ex.Message.ToString()}",
                     data = "",
                     code = 400
                 }
               );
        }

    }

    [HttpPut]
    [Route("Update/{Id}")]
    public async Task<IActionResult> Update(TEntity model, short Id)
    {
        try
        {
            var entity = await _context.Set<TEntity>().FindAsync(new { Id = Id });
            if (entity == null)
            {
                throw new System.Exception($"Not found item with id = {Id}");
            }
            //  model.Id  = Id;
            entity = model;
            entity.Id = Id;
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return Ok(
              new
              {
                  message = $"Update {typeof(TEntity)} sucesss",
                  data = entity,
                  code = 201
              }
            );
        }
        catch (System.Exception ex)
        {

            return Ok(
                 new
                 {
                     message = $"Update {typeof(TEntity)} fail: {ex.Message.ToString()}",
                     data = "",
                     code = 400
                 }
               );
        }

    }

    [HttpDelete]
    [Route("Delete/{Id}")]
    public async Task<IActionResult> Delete(int Id)
    {
        try
        {
            var entity = await _context.Set<TEntity>().FindAsync(new { Id = Id });
            if (entity == null)
            {
                throw new System.Exception($"Not found item with id = {Id}");
            }
            //  model.Id  = Id;

            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return Ok(
              new
              {
                  message = $"Delete {typeof(TEntity)} sucesss",
                  data = entity,
                  code = 200
              }
            );
        }
        catch (System.Exception ex)
        {

            return Ok(
                 new
                 {
                     message = $"Delete {typeof(TEntity)} fail: {ex.Message.ToString()}",
                     data = "",
                     code = 400
                 }
               );
        }

    }
}