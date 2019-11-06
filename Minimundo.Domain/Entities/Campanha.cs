using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Campanha : BaseEntity
    {
        public int CampanhaID { get; set; }
        public int EmpresaID { get; set; }
        public int AvaliadorID { get; set; }
        public string Responsavel { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime InicioPeriodo { get; set; }
        public DateTime FimPeriodo { get; set; }
        public decimal ValorPremio { get; set; }
        public char Status { get; set; }
    }
}
