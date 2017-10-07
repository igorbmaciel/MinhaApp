﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Domain.Models;

namespace MinhaApp.Domain.Repositories
{
    public interface IProcessoRepository
    {
        List<Processo> BuscarProcessos();
        void InserirProcesso(Processo processo);

        void AtualizarProcesso(Processo processo);

        void ExcluirProcesso(int Id);
    }
}
