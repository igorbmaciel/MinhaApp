using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Domain.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string InscricaoMunicipal { get; set; }
        public Decimal ReceitaBruta { get; set; }
        public Endereco Endereco { get; set; }
        public Produto Produto { get; set; }

    }
    
}
