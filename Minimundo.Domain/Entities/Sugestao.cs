using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Sugestao : BaseEntity
    {
        public int SugestaoID { get; set; }
        public int CampanhaID { get; set; }
        public int FuncionarioID { get; set; }
        public string Descricao { get; set; }


    }
}
