using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFrotas.Models.Domain.Entites
{
    public class Veiculo
    {
        public string VeiculoId { get; set; }
        
        public string Modelo { get; set; }

        public string Placa { get; set; }

        public int Ano { get; set; }
        public IList<MotoristaVeiculo> Motoristas { get; set; }

        public Veiculo()
        {
            VeiculoId = string.IsNullOrEmpty(VeiculoId) ? BaseEntity.GenerateId() : string.Empty;
        }
    }
}
