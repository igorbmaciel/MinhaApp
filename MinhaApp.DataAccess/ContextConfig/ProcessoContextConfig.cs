using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Domain.Models;

namespace MinhaApp.DataAccess.ContextConfig
{
    public class ProcessoContextConfig : EntityTypeConfiguration<Processo>
    {
        public ProcessoContextConfig()
        {
            ToTable("Processo");
            HasKey(x => x.Id);
        }
    }
}
