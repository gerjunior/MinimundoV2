namespace Minimundo.Domain.Entities
{
    public class Funcionario : BaseEntity
    {
        public int FuncionarioID { get; set; }
        public int UsuarioID { get; set; }
        public int EmpresaID { get; set; }

        public Usuario Usuario { get; set; }
        public Empresa Empresa { get; set; }
    }
}
