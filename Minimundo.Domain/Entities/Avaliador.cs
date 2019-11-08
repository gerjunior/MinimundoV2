namespace Minimundo.Domain.Entities
{
    public class Avaliador : BaseEntity
    {
        public int AvaliadorID { get; set; }
        public int UsuarioID { get; set; }

        public Usuario Usuario { get; set; }
    }
}
