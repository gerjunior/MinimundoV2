namespace Minimundo.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public int UsuarioID { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public char Sexo { get; set; }
    }
}