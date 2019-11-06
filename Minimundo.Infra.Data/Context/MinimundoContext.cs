using Microsoft.EntityFrameworkCore;
using Minimundo.Domain.Entities;
using Minimundo.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Infra.Data.Context
{
    public class MinimundoContext : DbContext
    {
        public DbSet<Campanha> campanha { get; set; }
        public DbSet<Avaliador> avaliador { get; set; }
        public DbSet<CustoSugestao> custoSugestao { get; set; }
        public DbSet<Empresa> empresa { get; set; }
        public DbSet<Endereco> endereco { get; set; }
        public DbSet<Funcionario> funcionario { get; set; }
        public DbSet<Sugestao> sugestao { get; set; }
        public DbSet<SugestaoAvaliacao> sugestaoAvaliacao { get; set; }
        public DbSet<Telefone> telefone { get; set; }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<UsuarioAcesso> usuarioAcesso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
                dbContextOptionsBuilder.UseSqlServer("Data Source=DESKTOP-Q7KUIDL;Initial Catalog=MINIMUNDO;Integrated Security=True");
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
            modelBuilder.Entity<UsuarioAcesso>(new UsuarioAcessoMap().Configure);
        }
    }
}
