using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Funcionario : BaseEntity
    {
        public int FuncionarioID { get; set; }
        public int UsuarioID { get; set; }
        public int EmpresaID { get; set; }
    }
}
