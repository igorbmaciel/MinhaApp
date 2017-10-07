using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Domain.Models;

namespace MinhaApp.DataAccess.ContextConfig
{
    public class EnderecoContextConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoContextConfig()
        {
            ToTable("Endereco");
            HasKey(x => x.Id);
        }
    }
}
