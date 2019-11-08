using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class CustoSugestao : BaseEntity
    {
        public int CustoSugestaoID { get; set; }
        public int SugestaoID { get; set; }
        public string DescricaoCusto { get; set; }
        public decimal Valor { get; set; }

        public Sugestao Sugestao { get; set; }
    }
}
