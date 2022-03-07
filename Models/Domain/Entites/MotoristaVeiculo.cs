using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFrotas.Models.Domain.Entites
{
    public class MotoristaVeiculo
    {
        [Column(TypeName = "varchar(50)")]
        public string MotoristaId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string VeiculoId { get; set; }
        public Motorista Motorista { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
