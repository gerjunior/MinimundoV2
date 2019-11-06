using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Avaliador : BaseEntity
    {
        public int AvaliadorID { get; set; }
        public int UsuarioID { get; set; }
    }
}
