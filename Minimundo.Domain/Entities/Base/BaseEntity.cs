using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class BaseEntity
    {
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime ModificadoEm { get; set; }
        public bool Ativo { get; set; }
    }
}
