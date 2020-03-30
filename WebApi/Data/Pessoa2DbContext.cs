using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class PessoaDbContext: IdentityDbContext
    {
        public PessoaDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Models.Pessoa2> Pessoa2 { get; set; }
    }
}