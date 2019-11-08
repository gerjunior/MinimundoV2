namespace Minimundo.Domain.Entities
{
    public class Sugestao : BaseEntity
    {
        public int SugestaoID { get; set; }
        public int CampanhaID { get; set; }
        public int FuncionarioID { get; set; }
        public string Descricao { get; set; }

        public Campanha Campanha { get; set; }
        public Funcionario Funcionario { get; set; }


    }
}
