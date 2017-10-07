using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Domain.Models;

namespace MinhaApp.Domain.Repositories
{
    public interface IAutoInfracaoRepository
    {
        void CriarAutoInfracao(AutoInfracao autoInfracao);
    }
}
