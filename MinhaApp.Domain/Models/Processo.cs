using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Domain.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string RelatoFiscalizacao { get; set; }
        public DateTime DataRelato { get; set; }
        public string FiscalResponsavel { get; set; }
    }
}
