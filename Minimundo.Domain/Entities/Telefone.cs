using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Telefone : BaseEntity
    {
        public int TelefoneID { get; set; }
        public int UsuarioID { get; set; }
        public char Tipo { get; set; }
        public string DDI { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }

        public Telefone Telefone { get; set; }
    }
}
