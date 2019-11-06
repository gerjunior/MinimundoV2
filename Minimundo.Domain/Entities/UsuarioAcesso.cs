using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class UsuarioAcesso : BaseEntity
    {
        public int UserID { get; set; }
        public string AccessKey { get; set; }
    }
}
