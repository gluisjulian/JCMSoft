using System.ComponentModel.DataAnnotations;

namespace JCMSoft.Domain.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Propriedade de Navegação
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
    }
}
