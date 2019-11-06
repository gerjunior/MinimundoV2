using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class SugestaoAvaliacao : BaseEntity
    {
        public int SugestaoAvaliacaoID { get; set; }
        public int SugestaoID { get; set; }
        public decimal Nota { get; set; }
        public string Informacao { get; set; }
    }
}
