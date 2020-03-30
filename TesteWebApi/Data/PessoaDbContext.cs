using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TesteWebApi.Data
{
    public class PessoaDbContext : IdentityDbContext
    {
        public PessoaDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Models.Pessoa> Pessoa { get; set; }
    }
}
