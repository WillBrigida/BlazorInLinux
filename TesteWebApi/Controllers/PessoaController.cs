using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWebApi.Controllers
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
        public async Task<ActionResult<List<Models.Pessoa>>> GetCondominos()
        {
            var t = await _db.Pessoa.ToListAsync();
            
            return  t;
        }
    }
}
