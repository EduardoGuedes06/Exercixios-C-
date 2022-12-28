using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface IArte
    {
        String Nome { get; set; }
        String Descricao { get; set; }
        void ExibiDados();
    }
}
