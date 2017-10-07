using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Domain.Models;

namespace MinhaApp.DataAccess.ContextConfig
{
    public class FornecedorContextConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorContextConfig()
        {
            ToTable("Fornecedor");
            HasKey(x => x.Id);
        }
    }
}
