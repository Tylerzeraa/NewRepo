﻿using FinanSmart.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.Interface.Repository
{
    public interface ICadastroRepository
    {
        public void AdicionarCadastro(Cadastro cadastro);
    }
}
