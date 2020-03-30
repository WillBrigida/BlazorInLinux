using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TesteWebApi.Models
{
    public partial class pessoa_dbContext : DbContext
    {
        public pessoa_dbContext()
        {
        }

        public pessoa_dbContext(DbContextOptions<pessoa_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PessoaTbl> PessoaTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=Arthuramordopai@02;database=pessoa_db", x => x.ServerVersion("10.2.11-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaTbl>(entity =>
            {
                entity.ToTable("pessoa_tbl");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idade)
                    .HasColumnName("idade")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
