﻿using ControleClientes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos.Interfaces
{
    public interface IAgenciaRepositorio : IRepositorioBase<Agencia>
    {
        IEnumerable<Agencia> BuscarAgenciaPorNome(string nome);
    }
}
