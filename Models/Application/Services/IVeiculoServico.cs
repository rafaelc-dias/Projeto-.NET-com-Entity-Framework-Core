using ControleFrotas.Models.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIControleFrotas.Models.Application.Services
{
    public interface IVeiculoServico
    {
        Task Cadastrar(Veiculo veiculo);
        Task Atualizar(Veiculo veiculo);
        Task<List<Veiculo>> Listar();
        Task<List<Veiculo>> Listar2();
        Task Excluir(string veiculoId);
        Task<Veiculo> Pesquisar(string veiculoId);
    }
}
