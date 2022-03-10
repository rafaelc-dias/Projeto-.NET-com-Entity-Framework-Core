using ControleFrotas.Models.Domain.Entites;
using ControleFrotas.Models.Insfrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIControleFrotas.Models.Infrastructure.Repositories
{
    public class VeiculoRepositorioImpl : IVeiculoRepositorio
    {
        private readonly ControleFrotaContext context;
        public VeiculoRepositorioImpl(ControleFrotaContext context)
        {
            this.context = context;
        }

        public async Task Atualizar(Veiculo veiculo)
        {
            var veiculopesquisado = await Pesquisar(veiculo.VeiculoId);
            if (veiculo != null && !string.IsNullOrEmpty(veiculo.VeiculoId) && veiculo.VeiculoId.Equals(veiculo.VeiculoId))
            {
                veiculopesquisado.Modelo = veiculo.Modelo;
                veiculopesquisado.Placa = veiculo.Placa;
                veiculopesquisado.Ano = veiculo.Ano;

                context.Veiculos.Update(veiculopesquisado);
                await context.SaveChangesAsync();
            }

                
        }

        public async Task Cadastrar(Veiculo veiculo)
        {
            await context.Veiculos.AddAsync(veiculo);
            await context.SaveChangesAsync();
        }

        public async Task Excluir(string veiculoId)
        {
            var veiculo = await Pesquisar(veiculoId);
            if (veiculo != null && !string.IsNullOrEmpty(veiculo.VeiculoId) && veiculo.VeiculoId.Equals(veiculoId))
                context.Remove(veiculo);
                await context.SaveChangesAsync();
        }

        public async Task<List<Veiculo>> Listar()
        {
            return await context.Veiculos.ToListAsync();
        }

        public async Task<List<Veiculo>> Listar2()
        {
            var result = await context.Veiculos
                .Include(x => x.Motoristas)
                .ThenInclude(xx => xx.Veiculo)
                .ToListAsync();

            foreach (var veiculo in result)
            {
                foreach (var itemveiculo in veiculo.Motoristas)
                {
                    itemveiculo.Motorista = await context.Motoristas.FirstOrDefaultAsync(m => m.MotoristaId.Equals(itemveiculo.MotoristaId));
                }
            }   


            return result;
        }

        public async Task<Veiculo> Pesquisar(string veiculoId)
        {
            return await context.Veiculos.FirstOrDefaultAsync(v => v.VeiculoId.Equals(veiculoId));
        }
    }
}
