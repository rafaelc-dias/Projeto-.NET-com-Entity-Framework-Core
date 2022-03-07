using ControleFrotas.Models.Domain.Entites;
using ControleFrotas.Models.Insfrastructure.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIControleFrotas.Models.Infrastructure.Repositories
{
    public class VeiculoRepositorioImpl : VeiculoRepositorio
    {
        private readonly ControleFrotaContext context;
        public VeiculoRepositorioImpl(ControleFrotaContext context)
        {
            this.context = context;
        }

        public Task Atualizar(Veiculo veiculo)
        {
            throw new System.NotImplementedException();
        }

        public Task Cadastrar(Veiculo veiculo)
        {
            throw new System.NotImplementedException();
        }

        public Task Excluir(string veiculoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Veiculo>> Listar()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Veiculo>> Listar2()
        {
            throw new System.NotImplementedException();
        }

        public Task<Veiculo> Pesquisar(string veiculoId)
        {
            throw new System.NotImplementedException();
        }
    }
}
