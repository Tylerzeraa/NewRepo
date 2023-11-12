using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSmart.Dominio.Interface.Repository
{
    public interface ILoginService
    {
        bool IsValid(string email, string password);
    }
}
