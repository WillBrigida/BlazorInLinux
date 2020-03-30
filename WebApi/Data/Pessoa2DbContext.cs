using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class PessoaDbContext: IdentityDbContext
    {
        public PessoaDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Models.Pessoa3> Pessoa3 { get; set; }
    }
}