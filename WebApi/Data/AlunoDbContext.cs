using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class AlunoDbContext: IdentityDbContext
    {
        public AlunoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Models.Aluno> Aluno { get; set; }
    }
}