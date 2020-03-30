using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly Data.AlunoDbContext _db;
        public AlunoController(Data.AlunoDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models.Aluno>>> GetCondominos()
        {
            var t = await _db.Aluno.ToListAsync();
            
            return  t;
        }
    }
}
