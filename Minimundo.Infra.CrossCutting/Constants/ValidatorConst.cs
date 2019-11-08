using System;
using System.Text.RegularExpressions;

namespace Minimundo.Infra.CrossCutting
{
    public struct ValidatorConst
    {
        public const string Nulo = "Obrigatório inserir";
        public const string Vazio = "Obrigatório preencher as informações do campo";
        public const string Maximo = "A quantidade máxima de caracteres para o campo";

        public static bool CNPJ(string CNPJ)
        {
            Regex rgx = new Regex(@"[0 - 9]{ 2}\.?[0-9]{3}\.?[0 - 9]{3}\/?[0 - 9]{4}\-?[0 - 9]{2}");

            return rgx.IsMatch(CNPJ);
        }
        public static bool CPF(string CPF)
        {
            Regex rgx = new Regex(@"[0-9]{3}\.[0-9]{3}\.[0-9]{3}-[0-9]{2}");

            return rgx.IsMatch(CPF);
        }
        public static bool Senha(string Senha)
        {
            Regex rgx = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            return rgx.IsMatch(Senha);
        }
    }
}
