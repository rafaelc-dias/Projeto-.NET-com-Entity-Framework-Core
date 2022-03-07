using ControleFrotas.Models.Domain.Entites;

namespace ControleFrotas.Models.DTO
{
    public class VeiculoDTO
    {
        public string VeiculoId { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }

        public Veiculo ConverteParaEntidade()
        {
            var novoveiculo = new Veiculo();
            novoveiculo.Ano = Ano;
            novoveiculo.VeiculoId = !string.IsNullOrEmpty(VeiculoId) ? VeiculoId : BaseEntity.GenerateId();
            novoveiculo.Placa = Placa;
            novoveiculo.Modelo = Modelo;

            return novoveiculo;

        }
    }
}
