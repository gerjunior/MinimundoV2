using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Empresa : BaseEntity
    {
        public int EmpresaID { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
    }
}
