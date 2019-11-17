using Microsoft.EntityFrameworkCore;
using Minimundo.Domain.Entities;
using Minimundo.Infra.Data.Mapping;

namespace Minimundo.Infra.Data.Context
{
    public class MinimundoContext : DbContext
    {
        public MinimundoContext(DbContextOptions<MinimundoContext> options) : base(options)
        {

        }
        public DbSet<Campanha> Campanha { get; set; }
        public DbSet<Avaliador> Avaliador { get; set; }
        public DbSet<CustoSugestao> CustoSugestao { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Sugestao> Sugestao { get; set; }
        public DbSet<SugestaoAvaliacao> SugestaoAvaliacao { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        //public DbSet<UserToken> UsuarioAcesso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q7KUIDL;Initial Catalog=MINIMUNDO;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Avaliador>(new AvaliadorMap().Configure);
            modelBuilder.Entity<Campanha>(new CampanhaMap().Configure);
            modelBuilder.Entity<Endereco>(new EnderecoMap().Configure);
            modelBuilder.Entity<CustoSugestao>(new CustoSugestaoMap().Configure);
            modelBuilder.Entity<Empresa>(new EmpresaMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
            modelBuilder.Entity<SugestaoAvaliacao>(new SugestaoAvaliacaoMap().Configure);
            modelBuilder.Entity<Sugestao>(new SugestaoMap().Configure);
            modelBuilder.Entity<Telefone>(new TelefoneMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            //modelBuilder.Entity<UserToken>(new UsuarioAcessoMap().Configure);
        }
    }
}