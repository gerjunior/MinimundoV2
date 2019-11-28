using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Resposta
    {
        public bool Valido { get; set; }
        public string Mensagem { get; set; }
        public dynamic Data { get; set; }

        public void Add(string mensagem, bool valido, dynamic data)
        {
            Valido = valido;
            Mensagem = mensagem;
            Data = data;
        }
    }
}
