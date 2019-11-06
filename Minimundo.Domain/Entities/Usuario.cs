using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public int UsuarioID { get; set; }
        public string Email { get; set; }
    }
}
