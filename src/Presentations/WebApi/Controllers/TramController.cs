using Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TramController : BaseApiController<HbDiem> 
    {
        public TramController(ApplicationDbContext context) : base(context)
        {
        }
    }
}