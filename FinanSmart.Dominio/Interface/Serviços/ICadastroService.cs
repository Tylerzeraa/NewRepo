using FinanSmart.Dominio.Entities;
using FinanSmart.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.Interface.Serviços
{
    public interface ICadastroService
    {
        public void AdicionarCadastro(Cadastro cadastro);
    }
}
