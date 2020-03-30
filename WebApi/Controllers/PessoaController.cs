using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly Data.PessoaDbContext _db;
        public PessoaController(Data.PessoaDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models.Pessoa2>>> GetCondominos()
        {
            var t = await _db.Pessoa2.ToListAsync();
            
            return  t;
        }
    }
}
