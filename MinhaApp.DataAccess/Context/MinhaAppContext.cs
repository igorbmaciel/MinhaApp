using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.DataAccess.ContextConfig;
using MinhaApp.Domain.Models;

namespace MinhaApp.DataAccess.Context
{
    public class MinhaAppContext : DbContext
    {
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Processo> Processo { get; set; }
        public DbSet<AutoInfracao> AutoInfracao { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Endereco> Endereco { get; set; }


        public MinhaAppContext() : base("name=BD_MinhaApp")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == "ID").Configure(p => p.IsKey());
            modelBuilder.Properties<String>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<String>().Configure(p => p.HasMaxLength(500));

            modelBuilder.Configurations.Add(new FornecedorContextConfig());
            modelBuilder.Configurations.Add(new ProcessoContextConfig());
            modelBuilder.Configurations.Add(new AutoInfracaoContextConfig());
            modelBuilder.Configurations.Add(new ProdutoContextConfig());
            modelBuilder.Configurations.Add(new EnderecoContextConfig());

        }
    }
}
